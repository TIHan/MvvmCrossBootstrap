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

