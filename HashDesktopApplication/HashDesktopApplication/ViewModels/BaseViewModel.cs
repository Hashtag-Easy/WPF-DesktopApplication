using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HashDesktopApplication.ViewModels
{
	public class BaseViewModel
	{
		private string title;
		private double defaultWindowHeight;
		private double defaultWindowWidth;

		public string Title 
		{ 
			get => title;
			set
			{
				title = value;
				OnPropertyChanged(nameof(Title));
			}
		}
		public double DefaultWindowHeight { get => defaultWindowHeight; set => defaultWindowHeight = value; }
		public double DefaultWindowWidth { get => defaultWindowWidth; set => defaultWindowWidth = value; }

		public event PropertyChangedEventHandler PropertyChanged;

		public BaseViewModel(string pageTitle, double defaultWindowHeight = 500, double defaultWindowWidth = 500)
		{
			Title = pageTitle;
			DefaultWindowHeight = defaultWindowHeight;
			DefaultWindowWidth = 1600;
		}

		protected void OnPropertyChanged([CallerMemberName] string? callerName = null)
		{
			if (callerName is null)
				return;

			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(callerName));
		}
	}
}
