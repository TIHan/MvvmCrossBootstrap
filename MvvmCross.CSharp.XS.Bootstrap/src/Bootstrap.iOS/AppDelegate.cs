namespace Bootstrap.iOS
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using MonoTouch.Foundation;
	using MonoTouch.UIKit;
	using Cirrious.MvvmCross.Touch.Platform;
	using Cirrious.MvvmCross.Touch.Views.Presenters;
	using Cirrious.MvvmCross.ViewModels;
	using Cirrious.CrossCore;
	using Bootstrap.Core;

	[Register ("AppDelegate")]
	public partial class AppDelegate : MvxApplicationDelegate
	{
		readonly UIWindow window = new UIWindow (UIScreen.MainScreen.Bounds);

		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			var presenter = new MvxTouchViewPresenter (this, window);

			var setup = new Setup (this, presenter);
			setup.Initialize ();

			var startup = Mvx.Resolve<IMvxAppStart> ();
			startup.Start ();

			// Hide Navigation Bar
			presenter.MasterNavigationController.SetNavigationBarHidden (true, false);
			window.MakeKeyAndVisible ();

			return true;
		}
	}
}