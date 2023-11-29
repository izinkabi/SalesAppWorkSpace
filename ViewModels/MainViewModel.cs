using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MSalesMobileApp.Pages;

namespace MSalesMobileApp.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    string username;

    [ObservableProperty]
    string password;

    [RelayCommand]
    async Task SignIn()
    {
        //Sign In
        if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
        {
            await Shell.Current.GoToAsync(nameof(CampaignsPage));
        }

        Password = string.Empty;
        Username = string.Empty;
    }
}
