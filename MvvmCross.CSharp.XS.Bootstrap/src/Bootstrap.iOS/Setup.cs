namespace Bootstrap.iOS
{
	using System;
	using Cirrious.MvvmCross.Touch.Platform;
	using Cirrious.MvvmCross.Touch.Views.Presenters;
	using Bootstrap.Core;

	public class Setup : MvxTouchSetup
	{
		public Setup (MvxApplicationDelegate appDelegate, IMvxTouchViewPresenter presenter)
			: base (appDelegate, presenter)
		{
		}

		protected override Cirrious.MvvmCross.ViewModels.IMvxApplication CreateApp ()
		{
			return new App ();
		}
	}
}

