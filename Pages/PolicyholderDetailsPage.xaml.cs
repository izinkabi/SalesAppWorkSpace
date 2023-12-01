using MSalesMobileApp.ViewModels;

namespace MSalesMobileApp.Pages;

public partial class PolicyholderDetailsPage : ContentPage
{
    public PolicyholderDetailsPage(PolicyholderViewModel policyHVM)
    {
        InitializeComponent();
        BindingContext = policyHVM;
    }
}