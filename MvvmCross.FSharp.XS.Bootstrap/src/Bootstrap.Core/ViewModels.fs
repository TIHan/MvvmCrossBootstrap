namespace Bootstrap.Core

open System
open System.Collections.ObjectModel
open Cirrious.MvvmCross.ViewModels

type BootstrapViewModel () as this = 
    inherit MvxViewModel () 

    let mutable clickCount = 0
    member this.ClickCount
        with get () = clickCount
        and private set value =
            clickCount <- value
            this.RaisePropertyChanged ("ClickCount")
            

    member __.ClickText
        with get () =
            match this.ClickCount with
            | 0 -> "MvvmCross Button"
            | x -> sprintf "Clicked %i times!" this.ClickCount
            
           
    member this.Click () =
        this.ClickCount <- this.ClickCount + 1
        
    member this.ClickCommand
        with get () = MvxCommand (fun () -> this.Click ())
        
    
            