using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MSalesMobileApp.Pages;
using System.Collections.ObjectModel;

namespace MSalesMobileApp.ViewModels;

public partial class CampaignsViewModel : ObservableObject
{


    [ObservableProperty]
    ObservableCollection<string> campaigns;
    [ObservableProperty]
    string name;
    public CampaignsViewModel()
    {
        Campaigns = new ObservableCollection<string>();

        //MKBattery
        Campaigns.Add("MKBattery");

        //MMKSecure
        Campaigns.Add("MMKSecure");

        //Zali
        Campaigns.Add("Zali");
        //Bonie yakasi
        Campaigns.Add("Bonie yakas");
    }

    [ObservableProperty]
    Campaign selectedCampaign;


    [RelayCommand]
    public async Task GotoCampaign()
    {
        //Go the selected campaign
        await Shell.Current.GoToAsync(nameof(EmployeeDetailsPage));


    }
}

public partial class Campaign : ObservableObject
{
    [ObservableProperty]
    public string name;
    [ObservableProperty]
    public string url;
}
