using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MSalesMobileApp.Pages;

namespace MSalesMobileApp.ViewModels
{
    public partial class PolicyholderViewModel : ObservableObject
    {
        public PolicyholderViewModel()
        {
            SelectedFileName = "Select File";
        }

        [ObservableProperty]
        string selectedFileName;
        [RelayCommand]
        public async Task GotoPaymentDetails()
        {
            await Shell.Current.GoToAsync(nameof(PaymentDetailsPage));
        }

        [RelayCommand]
        public async Task<FileResult> PickAndShow(PickOptions options)
        {
            try
            {
                var result = await FilePicker.Default.PickAsync(options);
                SelectedFileName = result.FileName;
                if (result != null)
                {
                    if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                        result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase) ||
                        result.FileName.EndsWith("pdf", StringComparison.OrdinalIgnoreCase))
                    {
                        using var stream = await result.OpenReadAsync();
                        var image = ImageSource.FromStream(() => stream);
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                // The user canceled or something went wrong
            }

            return null;
        }
    }
}
