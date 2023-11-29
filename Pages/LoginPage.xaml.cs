using MSalesMobileApp.ViewModels;

namespace MSalesMobileApp.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel loginVM)
    {
        InitializeComponent();
        BindingContext = loginVM;
    }
}