using BrownianMotionAPP.ViewModels;

namespace BrownianMotionAPP
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            if (BindingContext is MainViewModel viewModel)
            {
                if (e.Status == GestureStatus.Running)
                {
                    float scale = (float)e.Scale;
                    viewModel.Zoom(scale);
                }
            }
        }

    }

}
