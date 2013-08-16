namespace Bootstrap.Core
{
	using System;
	using Cirrious.MvvmCross.ViewModels;

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
	}
}

