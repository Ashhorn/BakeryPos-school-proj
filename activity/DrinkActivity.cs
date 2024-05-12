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
using Newtonsoft.Json;
using Android.Accounts;

namespace wtf.activity
{
    [Activity(Label = "DrinkActivity")]
    public class DrinkActivity : Activity
    {
        int ccount = 0;
        int kcount = 0;
        int scount = 0;
        int mcount = 0;
        int ucount = 0;
        int bcount = 0;
        int total = 0;
        TextView totaltxt;
        yeabro totalprice;
        Button breadbtn, cakebtn, drinkbtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DrinkLayout);
            breadbtn = FindViewById<Button>(Resource.Id.button1);
            cakebtn = FindViewById<Button>(Resource.Id.button2);
            drinkbtn = FindViewById<Button>(Resource.Id.button3);
            totaltxt = FindViewById<TextView>(Resource.Id.totaltxt);

            

            breadbtn.Click += Breadbtn_Click;
            cakebtn.Click += Cakebtn_Click;
            drinkbtn.Click += Drinkbtn_Click;


            totalprice = JsonConvert.DeserializeObject<yeabro>(Intent.GetStringExtra("Current"));

            totaltxt.Text = totalprice.totalp.ToString();

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
            {
                Intent intent = new Intent(this, typeof(BreadActivity));

                yeabro yeabro = new yeabro()
                {
                    txtqtymeat = mcount,
                    txtqtyube = ucount,
                    txtqtykwason = kcount,
                    txtqtybaguette = bcount,
                    txtqtycheese = ccount,
                    txtqtyspanish = scount,
                    totalp = total
                };

                // Add PutExtra method data to intent.    
                intent.PutExtra("Current", JsonConvert.SerializeObject(yeabro));

                // StartActivity    
                this.StartActivity(intent);
            }
        }
    }
}