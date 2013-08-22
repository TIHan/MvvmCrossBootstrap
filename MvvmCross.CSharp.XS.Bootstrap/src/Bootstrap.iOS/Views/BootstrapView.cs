namespace Bootstrap.iOS.Views
{
	using System;
	using System.Drawing;
	using MonoTouch.Foundation;
	using MonoTouch.UIKit;
	using Cirrious.MvvmCross.Touch.Views;
	using Cirrious.MvvmCross.Binding.BindingContext;
	using Cirrious.MvvmCross.Binding.Touch.Views;
	using Bootstrap.Core;

	class EnterTextDelegate : UITextFieldDelegate
	{
		public override bool ShouldReturn (UITextField textField)
		{
			textField.ResignFirstResponder ();
			return false;
		}
	}

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

			EnterText.Delegate = new EnterTextDelegate ();

			var itemListSource = new MvxSimpleTableViewSource (ItemList, "ItemView");

			var set = this.CreateBindingSet<BootstrapView, BootstrapViewModel> ();

			set.Bind (Click).For ("TouchUpInside").To ("ClickCommand").Apply ();
			set.Bind (Click).For ("Title").To ("ClickText").Apply ();
			set.Bind (GoToNavigate).For ("TouchUpInside").To ("GoToNavigateCommand").Apply ();
			set.Bind (EnterText).To ("EnterText").Apply ();
			set.Bind (DisplayText).For ("Text").To ("EnterText").Apply ();
			set.Bind (itemListSource).For ("ItemsSource").To ("Items").Apply ();

			ItemList.Source = itemListSource;
			ItemList.ReloadData ();
		}
	}
}

