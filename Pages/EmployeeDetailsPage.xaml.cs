using MSalesMobileApp.ViewModels;

namespace MSalesMobileApp.Pages;

public partial class EmployeeDetailsPage : ContentPage
{
    public EmployeeDetailsPage(EmployeeDetailsViewModel employeeVM)
    {
        InitializeComponent();
        BindingContext = employeeVM;
    }
}