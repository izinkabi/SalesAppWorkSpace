using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MSalesMobileApp.Pages;

namespace MSalesMobileApp.ViewModels;

public partial class LoginViewModel : ObservableObject
{

    [ObservableProperty]
    string username;
    [ObservableProperty]
    string password;

    [RelayCommand]
    public async Task GotoCampaigns()
    {
        if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrEmpty(Password))
            return;
        await Shell.Current.GoToAsync(nameof(CampaignsPage));
    }
}
