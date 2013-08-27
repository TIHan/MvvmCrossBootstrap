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

	[Register ("SubView")]
	public class SubView : MvxView
	{
		UILabel _text;
		public SubView (IntPtr handle) : base (handle)
		{
			_text = new UILabel (new RectangleF (0, 0, 256, 64));
			AddSubview (_text);

			this.DelayBind (() => {
				var set = this.CreateBindingSet<SubView, SubViewModel> ();

				set.Bind ().For ("TextText").To ("Text");
				set.Apply ();
			});
		}

		public string TextText
		{
			get { return _text.Text; }
			set { _text.Text = value; }
		}
	}
}

