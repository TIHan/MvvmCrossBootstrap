namespace Bootstrap.Core
{
	using System;
	using Cirrious.MvvmCross.ViewModels;
	using Cirrious.MvvmCross.Plugins.Messenger;

	public class NewViewModel : MvxViewModel
	{
		readonly IMvxMessenger _messenger;

		public  NewViewModel (IMvxMessenger messenger) : base ()
		{
			_messenger = messenger;
		}
	}
}

