using CommunityToolkit.Maui;
using JSONi18n.MASA.Helpers;
using JSONi18n.MASA.Services;
using JSONi18n.MASA.Shared;
using JSONi18n.MASA.Shared.IServices;

namespace JSONi18n.MASA;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp( )
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf" , "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf" , "OpenSansSemibold");
            });

        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddMasaBlazor(options =>
        {
            options.Locale = new BlazorComponent.Locale("zh-CN" , "en-US");
            options.ConfigureTheme(theme => theme.Dark = false);
        }).AddI18nForMauiBlazor("i18n");


        builder.AddMyServices();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Services.AddLogging();
#endif

        return builder.Build();
    }


    public static MauiAppBuilder AddMyServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddSingleton<IJsonService , YDataHandlerService>();
        builder.Services.AddSingleton<IPlatformService , YPlatformService>();
        return builder;
    }

}
