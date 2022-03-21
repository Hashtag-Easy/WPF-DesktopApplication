using System.ComponentModel;
using System.Runtime.CompilerServices;
using HashDesktopApplication.Attributes;

namespace HashDesktopApplication.ViewModels
{
	public class BaseViewModel
	{
		private string title = string.Empty;
		private double defaultWindowHeight = default;
		private double defaultWindowWidth = default;
		private 

		public string Title 
		{ 
			get => title;
			set
			{
				title = value;
				OnPropertyChanged(nameof(Title));
			}
		}
		public double DefaultWindowHeight
		{
			get => defaultWindowHeight;
			set
			{
				defaultWindowHeight = value;
				OnPropertyChanged(nameof(DefaultWindowHeight));
			}
		}
		public double DefaultWindowWidth
		{
			get => defaultWindowWidth;
			set
			{
				defaultWindowWidth = value;
				OnPropertyChanged(nameof(DefaultWindowWidth));
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		public BaseViewModel(string pageTitle, double defaultWindowHeight = 500, double defaultWindowWidth = 500)
		{
			Title = pageTitle;
			DefaultWindowHeight = defaultWindowHeight;
			DefaultWindowWidth = defaultWindowWidth;
		}

		protected void OnPropertyChanged([CallerMemberName] string? callerName = null)
		{
			if (callerName is null)
				return;

			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(callerName));
		}

		public enum SpecialEntityCode
		{
			[Value("")]
			NonBreakableSpace,

		}
	}
}
