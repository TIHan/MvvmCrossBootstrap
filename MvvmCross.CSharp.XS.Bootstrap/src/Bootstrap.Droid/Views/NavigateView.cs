namespace Bootstrap.Droid.Views
{
	using Android.App;
	using Cirrious.MvvmCross.Droid.Views;
	using Cirrious.MvvmCross.Binding.BindingContext;
	using Bootstrap.Core;

	[Activity (Label = "Navigate")]
	public class NavigateView : MvxActivity
	{
		public new NavigateViewModel ViewModel
		{
			get { return (NavigateViewModel) base.ViewModel; }
			set { base.ViewModel = value; }
		}

		protected override void OnViewModelSet ()
		{
			base.OnViewModelSet ();
			SetContentView (Resource.Layout.View_Navigate);
		}
	}
}