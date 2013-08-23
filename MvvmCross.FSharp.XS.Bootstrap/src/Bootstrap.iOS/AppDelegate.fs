namespace Bootstrap.iOS

open System
open System.Collections.Generic
open System.Linq
open MonoTouch.Foundation
open MonoTouch.UIKit
open Cirrious.MvvmCross.Touch.Platform
open Cirrious.MvvmCross.Touch.Views.Presenters
open Cirrious.MvvmCross.ViewModels
open Cirrious.CrossCore
open Bootstrap.Core

type Setup (appDelegate, presenter: IMvxTouchViewPresenter) =
    inherit MvxTouchSetup (appDelegate, presenter)
    
    override this.CreateApp () =
        App () :> IMvxApplication


[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit MvxApplicationDelegate ()

    let window = new UIWindow (UIScreen.MainScreen.Bounds)

    override this.FinishedLaunching (app, options) =
        let presenter = MvxTouchViewPresenter (this, window)
        
        let setup = Setup (this, presenter)
        setup.Initialize ()
        
        let startup = Mvx.Resolve<IMvxAppStart> ()
        startup.Start ()
        
        presenter.MasterNavigationController.SetNavigationBarHidden (true, false)
        window.MakeKeyAndVisible ()

        true


module Main =
    [<EntryPoint>]
    let main args =
        UIApplication.Main (args, null, "AppDelegate")
        0

