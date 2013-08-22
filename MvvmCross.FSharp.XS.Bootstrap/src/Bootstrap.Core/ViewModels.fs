namespace Bootstrap.Core

open System
open System.Collections.ObjectModel
open Cirrious.MvvmCross.ViewModels

type SimpleAgent<'State, 'Msg> (initial: 'State, execute) =
    let mailbox = new MailboxProcessor<'Msg> (fun agent ->
        let rec loop (state: 'State)  =
            async {
                let! msg = agent.Receive ()
                return! loop (execute state msg)
            }
        loop initial)
        
    member this.Start () =
        mailbox.Start ()

    member this.Post msg =
        mailbox.Post msg
    
    member this.PostAndReply<'Reply> msg : 'Reply =
        mailbox.PostAndReply msg
        
    member this.TryPostAndReply<'Reply> msg timeout : Option<'Reply> =
        mailbox.TryPostAndReply (msg, timeout)
        
    static member StartNew initial execute =
        let agent = SimpleAgent (initial, execute)
        agent.Start ()
        agent


type BootstrapMessage =
    | GetClickCount of AsyncReplyChannel<int>
    | SetClickCount of int

type Bootstrap =
    {
        ClickCount : int;
    }  

type BootstrapViewModel () as this = 
    inherit MvxViewModel () 
    
    let agent = SimpleAgent.StartNew (Unchecked.defaultof<Bootstrap>) (fun state msg ->
        match msg with
        
        | GetClickCount channel ->
            channel.Reply state.ClickCount
            state

        | SetClickCount clickCount ->
            { state with ClickCount = clickCount }
    )

    member this.ClickCount
        with get () = agent.PostAndReply (fun x -> GetClickCount x)
        and private set value =
            agent.Post (SetClickCount value)
            this.RaisePropertyChanged ("ClickCount")
            

    member this.ClickText
        with get () =
            match this.ClickCount with
            | 0 -> "MvvmCross Button"
            | x -> sprintf "Clicked %i times!" x
            
           
    member this.Click () =
        this.ClickCount <- this.ClickCount + 1
        
    member this.ClickCommand
        with get () = MvxCommand (fun () -> this.Click ())
        
    
            