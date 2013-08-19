namespace Bootstrap.iOS.Views
{
	using System;
	using System.Drawing;
	using MonoTouch.Foundation;
	using MonoTouch.UIKit;
	using Cirrious.MvvmCross.Touch.Views;
	using Cirrious.MvvmCross.Binding.BindingContext;
	using Bootstrap.Core;

	public partial class NewView : MvxViewController
	{
		public new NewViewModel ViewModel
		{
			get { return (NewViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		public NewView () : base ("NewView", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}
	}
}

