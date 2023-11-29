using MSalesMobileApp.ViewModels;

namespace MSalesMobileApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage(LoginViewModel loginVM)
        {
            InitializeComponent();
            BindingContext = loginVM;
        }


    }

}
