namespace Bootstrap.Core
{
	using System;
	using System.Collections.ObjectModel;
	using Cirrious.MvvmCross.ViewModels;
	using Cirrious.MvvmCross.Plugins.Messenger;

	public class BootstrapViewModel : MvxViewModel
	{
		int _clickCount;
		public int ClickCount
		{
			get { return _clickCount; }
			set
			{
				_clickCount = value;
				RaisePropertyChanged (() => ClickCount);
				RaisePropertyChanged (() => ClickText);
			}
		}

		public string ClickText
		{
			get
			{
				if (ClickCount == 0)
				{
					return "MvvmCross Button";
				}
				else
				{
					return string.Format ("Clicked {0} times!", ClickCount);
				}
			}
		}

		public void Click ()
		{
			++ClickCount;
		}

		public IMvxCommand ClickCommand
		{
			get
			{
				return new MvxCommand (Click);
			}
		}

		public void GoToNavigate ()
		{
			ShowViewModel<NavigateViewModel> ();
		}

		public IMvxCommand GoToNavigateCommand
		{
			get
			{
				return new MvxCommand (GoToNavigate);
			}
		}

		string _enterText;
		public string EnterText
		{
			get { return _enterText; }
			set
			{
				_enterText = value;
				RaisePropertyChanged (() => EnterText);
			}
		}

		ObservableCollection<ItemViewModel> _items;
		public ObservableCollection<ItemViewModel> Items
		{
			get { return _items; }
			set
			{
				_items = value;
				RaisePropertyChanged (() => Items);
			}
		}

		readonly IMvxMessenger _messenger;

		readonly MvxSubscriptionToken _sendMessageClickedToken;

		public BootstrapViewModel (IMvxMessenger messenger) : base ()
		{
			_messenger = messenger;

			_sendMessageClickedToken = _messenger.Subscribe<SendMessageClicked> (msg => {
				Click ();
			});

			Items = new ObservableCollection<ItemViewModel> ();
			Items.Add (new ItemViewModel ());
			Items.Add (new ItemViewModel ());
		}
	}
}

