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
	[Register ("NavigateView")]
	partial class NavigateView
	{
		[Outlet]
		MonoTouch.UIKit.UIButton GoBack { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton SendMessage { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (SendMessage != null) {
				SendMessage.Dispose ();
				SendMessage = null;
			}

			if (GoBack != null) {
				GoBack.Dispose ();
				GoBack = null;
			}
		}
	}
}
