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
    [Activity(Label = "DrinkActivity")]
    public class DrinkActivity : Activity
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
            StartActivity(new Intent(Application.Context, typeof(DrinkActivity)));
        }

        private void Cakebtn_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Application.Context, typeof(CakeActivity)));
        }

        private void Breadbtn_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Application.Context, typeof(BreadActivity)));
        }
    }
}