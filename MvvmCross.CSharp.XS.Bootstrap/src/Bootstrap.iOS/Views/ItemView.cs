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

	public partial class ItemView : MvxTableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("ItemView", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("ItemView");

		public ItemView (IntPtr handle) : base (handle)
		{
			//var set = this.CreateBindingSet<ItemView, ItemViewModel> ();

			//set.Bind (Text).To ("Text").Apply ();
			var hey = Text;
		}

		public static ItemView Create ()
		{
			return (ItemView)Nib.Instantiate (null, null) [0];
		}
	}
}

