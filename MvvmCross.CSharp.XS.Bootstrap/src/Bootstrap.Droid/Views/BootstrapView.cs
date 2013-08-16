namespace Bootstrap.Droid.Views
{
	using Android.App;
	using Cirrious.MvvmCross.Droid.Views;
	using Cirrious.MvvmCross.Binding.BindingContext;
	using Bootstrap.Core;

	[Activity (Label = "Bootstrap", MainLauncher = true)]
	public class BootstrapView : MvxActivity
	{
		public new BootstrapViewModel ViewModel
		{
			get { return (BootstrapViewModel) base.ViewModel; }
			set { base.ViewModel = value; }
		}

		protected override void OnViewModelSet ()
		{
			base.OnViewModelSet ();
			SetContentView (Resource.Layout.View_Bootstrap);
		}
	}
}