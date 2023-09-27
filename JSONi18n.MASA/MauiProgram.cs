﻿using CommunityToolkit.Maui;
using JSONi18n.MASA.Helpers;
using JSONi18n.MASA.Shared;

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


        builder.Services.AddSingleton<WeatherForecastService>();

        return builder.Build();
    }
}
