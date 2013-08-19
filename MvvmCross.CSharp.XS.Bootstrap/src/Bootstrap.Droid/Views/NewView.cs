namespace Bootstrap.Droid.Views
{
	using Android.App;
	using Cirrious.MvvmCross.Droid.Views;
	using Cirrious.MvvmCross.Binding.BindingContext;
	using Bootstrap.Core;

	[Activity (Label = "New")]
	public class NewView : MvxActivity
	{
		public new NewViewModel ViewModel
		{
			get { return (NewViewModel) base.ViewModel; }
			set { base.ViewModel = value; }
		}

		protected override void OnViewModelSet ()
		{
			base.OnViewModelSet ();
			SetContentView (Resource.Layout.View_New);
		}
	}
}