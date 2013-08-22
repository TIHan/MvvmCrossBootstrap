namespace Bootstrap.Core
{
	using System;
	using Cirrious.MvvmCross.ViewModels;
	using Cirrious.MvvmCross.Plugins.Messenger;

	public class ItemViewModel : MvxViewModel
	{
		string _text;
		public string Text
		{
			get { return _text; }
			set
			{
				_text = value;
				RaisePropertyChanged (() => Text);
			}
		}

		public ItemViewModel ()
		{
			Text = "An Item :-)";
		}
	}
}

