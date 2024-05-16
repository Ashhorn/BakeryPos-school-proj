using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wtf.activity
{
    [Activity(Label = "POS", Theme = "@style/SplashTheme", MainLauncher =true, NoHistory =true, ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Intent intent = new Intent(this, typeof(BreadActivity));
            StartActivity(intent);
            // Create your application here
        }
    }
}