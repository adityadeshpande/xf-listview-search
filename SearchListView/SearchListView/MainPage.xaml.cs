using Xamarin.Forms;

namespace SearchListView
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new MainPageViewModel();
            this.BindingContext = this.viewModel;

        }
    }
}
