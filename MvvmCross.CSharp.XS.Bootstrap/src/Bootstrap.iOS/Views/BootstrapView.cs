namespace Bootstrap.iOS.Views
{
	using System;
	using System.Drawing;
	using MonoTouch.Foundation;
	using MonoTouch.UIKit;
	using Cirrious.MvvmCross.Touch.Views;
	using Cirrious.MvvmCross.Binding.BindingContext;
	using Bootstrap.Core;

	public partial class BootstrapView : MvxViewController
	{
		public new BootstrapViewModel ViewModel
		{
			get { return (BootstrapViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		public BootstrapView () : base ("BootstrapView", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var set = this.CreateBindingSet<BootstrapView, BootstrapViewModel> ();

			set.Bind (Click).For ("TouchUpInside").To ("ClickCommand").Apply ();
			set.Bind (Click).For ("Title").To ("ClickText").Apply ();
			set.Bind (GoToNavigate).For ("TouchUpInside").To ("GoToNavigateCommand").Apply ();
		}
	}
}

