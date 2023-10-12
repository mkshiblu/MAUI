using Android.App;
using Android.Content.PM;
using Android.OS;

namespace MauiDeepLinkNavigationBarIssue
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    [IntentFilter(new[] { Android.Content.Intent.ActionView },
                          AutoVerify = true,
                          Categories = new[]
                          {
                              global::Android.Content.Intent.CategoryDefault,
                              global::Android.Content.Intent.CategoryBrowsable
                          },
                          DataScheme = "DeepLink",
                          DataPath = "TitleIssue"
                        )]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }
    }
}