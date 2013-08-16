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
	}
}

