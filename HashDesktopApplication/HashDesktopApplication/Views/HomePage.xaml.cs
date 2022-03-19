using System.Windows.Controls;

namespace HashDesktopApplication.Views
{
	/// <summary>
	/// Interaction logic for HomePage.xaml
	/// </summary>
	public partial class HomePage : Page
	{
		public HomePage()
		{
			InitializeComponent();
			DataContext = new HomePageViewModel();
		}
	}
}
