using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace EdSampleBlazor
{
	public partial class App : Application
	{
		public App(CounterState counterState)
		{
			InitializeComponent();

			MainPage = new MainPage(counterState);
		}
	}
}
