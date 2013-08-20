namespace Bootstrap.iOS.Views
{
	using System;
	using System.Drawing;
	using MonoTouch.Foundation;
	using MonoTouch.UIKit;
	using Cirrious.MvvmCross.Touch.Views;
	using Cirrious.MvvmCross.Binding.BindingContext;
	using Bootstrap.Core;

	public partial class NavigateView : MvxViewController
	{
		public new NavigateViewModel ViewModel
		{
			get { return (NavigateViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		public NavigateView () : base ("NavigateView", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var set = this.CreateBindingSet<NavigateView, NavigateViewModel> ();

			set.Bind (SendMessage).For ("TouchUpInside").To ("SendMessageCommand").Apply ();
			set.Bind (GoBack).For ("TouchUpInside").To ("GoBackCommand").Apply ();
		}
	}
}