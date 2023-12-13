using MAUIdemo.ViewModel;

namespace MAUIdemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage(DefaultViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = new DefaultViewModel();
        }

    }

}
