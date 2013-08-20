// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Bootstrap.iOS.Views
{
	[Register ("BootstrapView")]
	partial class BootstrapView
	{
		[Outlet]
		MonoTouch.UIKit.UIButton Click { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel DisplayText { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField EnterText { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton GoToNavigate { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Click != null) {
				Click.Dispose ();
				Click = null;
			}

			if (GoToNavigate != null) {
				GoToNavigate.Dispose ();
				GoToNavigate = null;
			}

			if (EnterText != null) {
				EnterText.Dispose ();
				EnterText = null;
			}

			if (DisplayText != null) {
				DisplayText.Dispose ();
				DisplayText = null;
			}
		}
	}
}
