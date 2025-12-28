using Microsoft.Extensions.Logging;

namespace SolitaireEncryption
{
    /// <summary>
    /// Create a new MauiApp using the default application.
    /// </summary>
    /// <param name="additional"></param>
    /// <returns></returns>
    public static MauiApp CreateMauiApp(Action<MauiAppBuilder>? additional = null) =>
        CreateMauiApp<App>(additional);

    /// <summary>
    /// Create a new MauiAPp using the specified application.
    /// </summary>
    /// <typeparam name="TApp"></typeparam>
    /// <param name="additional"></param>
    /// <returns></returns>
    public static MauiApp CreateMauiApp<TApp>(Action<MauiAppBuilder>? additional = null) where TApp : App
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

#if DEBUG
		builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
