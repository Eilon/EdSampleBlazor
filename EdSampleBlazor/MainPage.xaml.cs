using System;
using Microsoft.Maui.Controls;

namespace EdSampleBlazor
{
	public partial class MainPage : ContentPage
	{
        private readonly CounterState _counterState;

        public MainPage(CounterState counterState)
		{
			InitializeComponent();
            _counterState = counterState;
			
			_counterState.OnChanged += () => UpdateCounterLabel();

			UpdateCounterLabel();
		}

		private void UpdateCounterLabel()
        {
			CounterLabel.Text = _counterState.CounterValue.ToString();
		}
	}
}
