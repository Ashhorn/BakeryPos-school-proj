using Android.App;
using Android.Content;
using Android.Nfc;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Google.Android.Material.Button;
using Google.Android.Material.TextField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace wtf.activity
{
    [Activity(Label = "MenuActivity", MainLauncher = true)]
    public class BreadActivity : Activity
    {
        Button breadbtn, cakebtn, drinkbtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.BreadLayout);
            breadbtn = FindViewById<Button>(Resource.Id.button1);
            cakebtn = FindViewById<Button>(Resource.Id.button2);
            drinkbtn = FindViewById<Button>(Resource.Id.button3);

            breadbtn.Click += Breadbtn_Click;
            cakebtn.Click += Cakebtn_Click;
            drinkbtn.Click += Drinkbtn_Click;
        }

        private void Drinkbtn_Click(object sender, EventArgs e)
        {
            Intent create = new Intent(this, typeof(DrinkActivity));
            StartActivity(create);
        }

        private void Cakebtn_Click(object sender, EventArgs e)
        {
            Intent create = new Intent(this, typeof(CakeActivity));
            StartActivity(create);
        }

        private void Breadbtn_Click(object sender, EventArgs e)
        {
            Intent create = new Intent(this, typeof(BreadActivity));
            StartActivity(create);
        }
    }
}