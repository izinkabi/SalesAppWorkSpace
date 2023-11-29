using Microsoft.Extensions.Logging;
using MSalesMobileApp.Pages;
using MSalesMobileApp.ViewModels;

namespace MSalesMobileApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddTransient<CampaignsViewModel>();
            builder.Services.AddTransient<CampaignsPage>();

            builder.Services.AddSingleton<PolicyholderDetailsPage>();
            builder.Services.AddSingleton<PolicyholderViewModel>();

            builder.Services.AddTransient<EmployeeDetailsPage>();
            builder.Services.AddTransient<EmployeeDetailsViewModel>();

            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<LoginViewModel>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
