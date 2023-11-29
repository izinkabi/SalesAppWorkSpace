using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MSalesMobileApp.Pages;

namespace MSalesMobileApp.ViewModels;

public partial class EmployeeDetailsViewModel : ObservableObject
{

    [RelayCommand]
    public async Task GotoPoliHolderCommand()
    {
        await Shell.Current.GoToAsync(nameof(PolicyholderDetailsPage));
    }
}
