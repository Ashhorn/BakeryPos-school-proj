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
        int mcount = 0;
        int ucount = 0;
        int ccount = 0;
        int kcount = 0;
        int scount = 0;
        int bcount = 0;

        int ncount = 0;
        int cokecount = 0;
        int rcount = 0;
        int wcount = 0;
        int c2count = 0;
        int total = 0;
        TextView totaltxt,textquantitywater,textquantityroyal,textquantityc2,textquantitycoke,textquantitynestea;
        yeabro totalprice;
        Button breadbtn, cakebtn, drinkbtn, minuswater,pluswater,minusc2,plusc2,minusroyal,plusroyal,minuscoke,pluscoke,minusnestea,plusnestea;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Check if an instance of BreadActivity is already running
            if (!IsTaskRoot && Intent.HasCategory(Intent.CategoryLauncher) && Intent.Action == Intent.ActionMain)
            {
                // Bring the existing instance of BreadActivity to the foreground
                Intent intent = new Intent(this, typeof(DrinkActivity));
                intent.AddFlags(ActivityFlags.SingleTop | ActivityFlags.ReorderToFront);
                StartActivity(intent);
                Finish();
                return;
            }
            SetContentView(Resource.Layout.DrinkLayout);

            breadbtn = FindViewById<Button>(Resource.Id.button1);
            cakebtn = FindViewById<Button>(Resource.Id.button2);
            drinkbtn = FindViewById<Button>(Resource.Id.button3);
            totaltxt = FindViewById<TextView>(Resource.Id.totaltxt);
            textquantitywater = FindViewById<TextView>(Resource.Id.textquantitywater);
            pluswater = FindViewById<Button>(Resource.Id.pluswater);
            minuswater = FindViewById<Button>(Resource.Id.minuswater);
            textquantityroyal = FindViewById<TextView>(Resource.Id.textquantityroyal);
            plusroyal = FindViewById<Button>(Resource.Id.plusroyal);
            minusroyal = FindViewById<Button>(Resource.Id.minusroyal);
            textquantityc2 = FindViewById<TextView>(Resource.Id.textquantityc2);
            minusc2 = FindViewById<Button>(Resource.Id.minusc2);
            plusc2 = FindViewById<Button>(Resource.Id.plusc2);
            textquantitycoke = FindViewById<TextView>(Resource.Id.textquantitycoke);
            minuscoke = FindViewById<Button>(Resource.Id.minuscoke);
            pluscoke = FindViewById<Button>(Resource.Id.pluscoke);
            textquantitynestea = FindViewById<TextView>(Resource.Id.textquantitynestea);
            minusnestea = FindViewById<Button>(Resource.Id.minusnestea);
            plusnestea = FindViewById<Button>(Resource.Id.plusnestea);



            pluswater.Click += Pluswater_Click;
            minuswater.Click += Minuswater_Click;
            plusroyal.Click += Plusroyal_Click;
            minusroyal.Click += Minusroyal_Click;
            plusc2.Click += Plusc2_Click;
            minusc2.Click += Minusc2_Click;
            pluscoke.Click += Pluscoke_Click;
            minuscoke.Click += Minuscoke_Click;
            minusnestea.Click += Minusnestea_Click;
            plusnestea.Click += Plusnestea_Click;
            breadbtn.Click += Breadbtn_Click;
            cakebtn.Click += Cakebtn_Click;
            drinkbtn.Click += Drinkbtn_Click;


            RunOnUiThread(() =>
            {
                totaltxt.Text = total.ToString();
            });

            string jsonString = Intent.GetStringExtra("Current");
            if (jsonString != null)
            {
                totalprice = JsonConvert.DeserializeObject<yeabro>(jsonString);

                total = totalprice.totalp; // Directly assign total price
            }

        }

        private void Plusnestea_Click(object sender, EventArgs e)
        {
            ncount++;
            int totnestea = ncount * 30;
            total += 30; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantitynestea.Text = $"{ncount}";
        }

        private void Minusnestea_Click(object sender, EventArgs e)
        {
            if (ncount > 0)
            {
                ncount--;
                int totnestea = c2count * 30;
                total -= 30; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantitynestea.Text = $"{ncount}";
        }

        private void Minuscoke_Click(object sender, EventArgs e)
        {
            if (cokecount > 0)
            {
                cokecount--;
                int totcoke = cokecount * 25;
                total -= 25; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantitycoke.Text = $"{cokecount}";
        }

        private void Pluscoke_Click(object sender, EventArgs e)
        {
            cokecount++;
            int totcoke = cokecount * 25;
            total += 25; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantitycoke.Text = $"{cokecount}";
        }

        private void Minusc2_Click(object sender, EventArgs e)
        {
            if (c2count > 0)
            {
                c2count--;
                int totc2 = c2count * 25;
                total -= 25; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantityc2.Text = $"{c2count}";
        }

        private void Plusc2_Click(object sender, EventArgs e)
        {
            c2count++;
            int totc2 = c2count * 25;
            total += 25; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantityc2.Text = $"{c2count}";
        }

        private void Minusroyal_Click(object sender, EventArgs e)
        {
            if (rcount > 0)
            {
                rcount--;
                int totroyal = rcount * 25;
                total -= 25; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantityroyal.Text = $"{rcount}";
        }

        private void Plusroyal_Click(object sender, EventArgs e)
        {
            rcount++;
            int totroyal = rcount * 25;
            total += 25; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantityroyal.Text = $"{rcount}";
        }

        private void Minuswater_Click(object sender, EventArgs e)
        {
            if (wcount > 0)
            {
                wcount--;
                int totwater = wcount * 15;
                total -= 15; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantitywater.Text = $"{wcount}";
        }

        private void Pluswater_Click(object sender, EventArgs e)
        {
            wcount++;
            int totwater = wcount * 15;
            total += 15; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantitywater.Text = $"{wcount}";
        }

        private void Drinkbtn_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "You are already in the activity", ToastLength.Short).Show();
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