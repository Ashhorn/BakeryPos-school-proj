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
using Newtonsoft.Json;

namespace wtf.activity
{
    [Activity(Label = "PoS", MainLauncher =false)]
    public class BreadActivity : Activity
    {
        int ccount = 0;
        int kcount = 0;
        int scount = 0;
        int mcount = 0;
        int ucount = 0;
        int bcount = 0;
        int total = 0;
        yeabro totalprice;
        TextView textquantitybaguette, totaltxt,textquantitycheese,textquantitymeat,textquantitykwason,textquantityube,textquantityspanish;
        Button breadbtn, cakebtn, drinkbtn, plusbagguete, minusbagguete, pluscheese, minuscheese,plusube, minusube,pluskwason, minuskwason, plusmeat, minusmeat, plusspanish, minusspanish;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Check if an instance of BreadActivity is already running
            if (!IsTaskRoot && Intent.HasCategory(Intent.CategoryLauncher) && Intent.Action == Intent.ActionMain)
            {
                // Bring the existing instance of BreadActivity to the foreground
                Intent intent = new Intent(this, typeof(BreadActivity));
                intent.AddFlags(ActivityFlags.SingleTop | ActivityFlags.ReorderToFront);
                StartActivity(intent);
                Finish();
                return;
            }

            // Continue with initializing your activity
            SetContentView(Resource.Layout.BreadLayout);

            breadbtn = FindViewById<Button>(Resource.Id.button1);
            cakebtn = FindViewById<Button>(Resource.Id.button2);
            drinkbtn = FindViewById<Button>(Resource.Id.button3);
            plusbagguete = FindViewById<Button>(Resource.Id.plusbaguette);
            minusbagguete = FindViewById<Button>(Resource.Id.minusbaguette);
            plusbagguete = FindViewById<Button>(Resource.Id.plusbaguette);
            minusbagguete = FindViewById<Button>(Resource.Id.minusbaguette);
            textquantitybaguette = FindViewById<TextView>(Resource.Id.textquantitybaguette);
            totaltxt = FindViewById<TextView>(Resource.Id.totaltxt);
            pluscheese = FindViewById<Button>(Resource.Id.pluscheese);
            minuscheese = FindViewById<Button>(Resource.Id.minuscheese);
            textquantitycheese = FindViewById<TextView>(Resource.Id.textquantitycheese);
            plusube = FindViewById<Button>(Resource.Id.plusube);
            minusube = FindViewById<Button>(Resource.Id.minusube);
            textquantityube = FindViewById<TextView>(Resource.Id.textquantityube);
            plusmeat = FindViewById<Button>(Resource.Id.plusmeat);
            minusmeat = FindViewById<Button>(Resource.Id.minusmeat);
            textquantitymeat = FindViewById<TextView>(Resource.Id.textquantitymeat);
            pluskwason = FindViewById<Button>(Resource.Id.pluskwason);
            minuskwason = FindViewById<Button>(Resource.Id.minuskwason);
            textquantitykwason = FindViewById<TextView>(Resource.Id.textquantitykwason);
            plusspanish = FindViewById<Button>(Resource.Id.plusspanish);
            minusspanish = FindViewById<Button>(Resource.Id.minusspanish);
            textquantityspanish = FindViewById<TextView>(Resource.Id.textquantityspanish);

            pluscheese.Click += Pluscheese_Click;
            minuscheese.Click += Minuscheese_Click;
            minusbagguete.Click += Minusbagguete_Click;
            breadbtn.Click += Breadbtn_Click;
            cakebtn.Click += Cakebtn_Click;
            drinkbtn.Click += Drinkbtn_Click;
            plusbagguete.Click += Plusbagguete_Click;
            plusube.Click += Plusube_Click;
            minusube.Click += Minusube_Click;
            plusmeat.Click += Plusmeat_Click;
            minusmeat.Click += Minusmeat_Click;
            pluskwason.Click += Pluskwason_Click;
            minuskwason.Click += Minuskwason_Click;
            plusspanish.Click += Plusspanish_Click;
            minusspanish.Click += Minusspanish_Click;

            int totspanish = scount * 5;
            int totkwason = kcount * 10;
            int totmeat = mcount * 15;
            int totube = ucount * 10;
            int totbaguette = bcount * 75;
            int totcheese = ccount * 7;
            total += totbaguette + totcheese +totube +totmeat +totkwason +totspanish;

            RunOnUiThread(() =>
            {
                totaltxt.Text = total.ToString();
            });

            string jsonString = Intent.GetStringExtra("Current");
            if (jsonString != null)
            {
                totalprice = JsonConvert.DeserializeObject<yeabro>(jsonString);
                bcount = totalprice.txtqtybaguette;
                total = totalprice.totalp; // Directly assign total price
            }
        }

        private void Minusspanish_Click(object sender, EventArgs e)
        {
            if (scount > 0)
            {
                scount--;
                int totcheese = scount * 5;
                total -= 5; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantityspanish.Text = $"{scount}";
        }

        private void Plusspanish_Click(object sender, EventArgs e)
        {
            scount++;
            int totcheese = scount * 5;
            total += 5; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantityspanish.Text = $"{scount}";
        }

        private void Minuskwason_Click(object sender, EventArgs e)
        {
            if (kcount > 0)
            {
                kcount--;
                int totcheese = kcount * 10;
                total -= 10; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantitykwason.Text = $"{kcount}";
        }

        private void Pluskwason_Click(object sender, EventArgs e)
        {
            kcount++;
            int totcheese = kcount * 10;
            total += 10; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantitykwason.Text = $"{kcount}";
        }

        private void Minusmeat_Click(object sender, EventArgs e)
        {
            if (mcount > 0)
            {
                mcount--;
                int totcheese = mcount * 15;
                total -= 15; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantitymeat.Text = $"{mcount}";
        }

        private void Plusmeat_Click(object sender, EventArgs e)
        {
            mcount++;
            int totcheese = mcount * 15;
            total += 15; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantitymeat.Text = $"{mcount}";
        }

        private void Minusube_Click(object sender, EventArgs e)
        {
            if (ucount > 0)
            {
                ucount--;
                int totcheese = ucount * 10;
                total -= 10; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantityube.Text = $"{ucount}";
        }

        private void Plusube_Click(object sender, EventArgs e)
        {
            ucount++;
            int totcheese = ucount * 10;
            total += 10; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantityube.Text = $"{ucount}";
        }

        private void Minuscheese_Click(object sender, EventArgs e)
        {
            if (ccount > 0)
            {
                ccount--;
                int totcheese = ccount * 7;
                total -= 7; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantitycheese.Text = $"{ccount}";
        }

        private void Pluscheese_Click(object sender, EventArgs e)
        {
            ccount++;
            int totcheese = ccount * 7;
            total += 7; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantitycheese.Text = $"{ccount}";
        }

        public void Minusbagguete_Click(object sender, EventArgs e)
        {
            if (bcount > 0)
            {
                bcount--;
                int totbaguette = bcount * 75;
                total -= 75; // Subtract the price of one baguette
                totaltxt.Text = total.ToString();
            }
            textquantitybaguette.Text = $"{bcount}";
        }


        public void Plusbagguete_Click(object sender, EventArgs e)
        {
            bcount++;
            int totbaguette = bcount * 75;
            total += 75; // Add the price of one baguette
            totaltxt.Text = total.ToString();
            textquantitybaguette.Text = $"{bcount}";
        }

        private void Drinkbtn_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(DrinkActivity));
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
            //Add PutExtra method data to intent.    
            intent.PutExtra("Current", JsonConvert.SerializeObject(yeabro));

            //StartActivity    
            StartActivity(intent);
        }

        private void Cakebtn_Click(object sender, EventArgs e)
        {
            Intent create = new Intent(this, typeof(CakeActivity));
            StartActivity(create);
        }

        private void Breadbtn_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "You are already in the activity", ToastLength.Short).Show();
        }
    }
}