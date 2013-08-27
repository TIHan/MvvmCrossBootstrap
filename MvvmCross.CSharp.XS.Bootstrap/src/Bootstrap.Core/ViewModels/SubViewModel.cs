namespace Bootstrap.Core
{
	using System;
	using Cirrious.MvvmCross.ViewModels;
	using Cirrious.MvvmCross.Plugins.Messenger;

	public class SubViewModel : MvxViewModel
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

		public SubViewModel ()
		{
			Text = "Sub View";
		}
	}
}

