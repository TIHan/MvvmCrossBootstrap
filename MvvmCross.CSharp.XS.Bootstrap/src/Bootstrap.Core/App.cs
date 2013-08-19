namespace Bootstrap.Core
{
	using Cirrious.CrossCore;
	using Cirrious.MvvmCross.ViewModels;

	public class App : MvxApplication
	{
		public App ()
		{
			Mvx.RegisterSingleton<IMvxAppStart> (new MvxAppStart<BootstrapViewModel> ());
			Cirrious.MvvmCross.Plugins.Messenger.PluginLoader.Instance.EnsureLoaded ();
		}
	}
}

