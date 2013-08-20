namespace Bootstrap.Core
{
	using System;
	using Cirrious.MvvmCross.ViewModels;
	using Cirrious.MvvmCross.Plugins.Messenger;

	public class SendMessageClicked : MvxMessage
	{
		public SendMessageClicked (object sender) : base (sender)
		{
		}
	}

	public class NavigateViewModel : MvxViewModel
	{
		public void SendMessage ()
		{
			_messenger.Publish (new SendMessageClicked (this));
		}

		public IMvxCommand SendMessageCommand
		{
			get
			{
				return new MvxCommand (SendMessage);
			}
		}

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

