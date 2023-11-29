using MSalesMobileApp.Pages;

namespace MSalesMobileApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CampaignsPage), typeof(CampaignsPage));
            Routing.RegisterRoute(nameof(EmployeeDetailsPage), typeof(EmployeeDetailsPage));
            Routing.RegisterRoute(nameof(PolicyholderDetailsPage), typeof(PolicyholderDetailsPage));

            Routing.RegisterRoute(nameof(PaymentDetailsPage), typeof(PaymentDetailsPage));
        }
    }
}
