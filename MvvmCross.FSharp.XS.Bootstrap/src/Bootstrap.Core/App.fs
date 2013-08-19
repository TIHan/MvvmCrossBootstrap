namespace Bootstrap.Core

open Cirrious.CrossCore
open Cirrious.MvvmCross.ViewModels

type App () = 
    inherit MvxApplication ()
    
    do
        Mvx.RegisterSingleton<IMvxAppStart> (MvxAppStart<BootstrapViewModel> ())
