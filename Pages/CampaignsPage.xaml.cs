using MSalesMobileApp.ViewModels;

namespace MSalesMobileApp.Pages;

public partial class CampaignsPage : ContentPage
{
    public CampaignsPage(CampaignsViewModel campaignsViewModel)
    {
        InitializeComponent();
        BindingContext = campaignsViewModel;
    }


}