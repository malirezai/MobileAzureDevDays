using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using Xamarin.Forms;
using System.Reflection;

[assembly: Xamarin.Forms.Dependency(typeof(MobileAzureDevDays.IToolbarColor))]
namespace MobileAzureDevDays.Droid
{
    [Activity(Label = "MobileAzureDevDays.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, IToolbarColor
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
        }

		public void ChangeColor(Xamarin.Forms.Color _color)
        {
            var droidColor = _color.ToAndroid();
            var window = ((MainActivity)Xamarin.Forms.Forms.Context).Window;
            window.SetStatusBarColor(darkenColor(droidColor));
        }

        static Android.Graphics.Color darkenColor(Android.Graphics.Color color)
        {
            float[] hsv = new float[3];
            Android.Graphics.Color.ColorToHSV(color, hsv);
            hsv[2] *= 0.8f;
            return Android.Graphics.Color.HSVToColor(hsv);
        }
    }
}
