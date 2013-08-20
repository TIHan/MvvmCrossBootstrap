namespace Bootstrap.Core
{
	using System;
	using Cirrious.MvvmCross.ViewModels;
	using Cirrious.MvvmCross.Plugins.Messenger;

	public class NavigateViewModel : MvxViewModel
	{
		public void GoBack ()
		{
			Close (this);
		}

		public IMvxCommand GoBackCommand
		{
			get
			{
				return new MvxCommand (GoBack);
			}
		}

		readonly IMvxMessenger _messenger;

		public  NavigateViewModel (IMvxMessenger messenger) : base ()
		{
			_messenger = messenger;
		}
	}
}

