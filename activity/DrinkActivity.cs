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
        int cheesecakecount = 0;
        int chococakecount = 0;
        int ubecakecount = 0;
        int oreocakecount = 0;
        int carrotcakecount = 0;
        int nesteacount = 0;
        int cokecount = 0;
        int royalcount = 0;
        int watercount = 0;
        int c2count = 0;
        int cheesecount = 0;
        int kwasoncount = 0;
        int spanishcount = 0;
        int meatcount = 0;
        int ubecount = 0;
        int baguettecount = 0;
        int total = 0;
        TextView totaltxt,textquantitywater,textquantityroyal,textquantityc2,textquantitycoke,textquantitynestea;
        yeabro totalprice;
        Button breadbtn, cakebtn, drinkbtn, minuswater,pluswater,minusc2,plusc2,minusroyal,plusroyal,minuscoke,pluscoke,minusnestea,plusnestea,buttondone;
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
            buttondone = FindViewById<Button>(Resource.Id.buttonDone);
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


            buttondone.Click += Buttondone_Click;
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


            if (savedInstanceState != null)
            {
                cheesecount = savedInstanceState.GetInt("cheesecount");
                kwasoncount = savedInstanceState.GetInt("kwasoncount");
                spanishcount = savedInstanceState.GetInt("spanishcount");
                meatcount = savedInstanceState.GetInt("meatcount");
                ubecount = savedInstanceState.GetInt("ubecount");
                baguettecount = savedInstanceState.GetInt("baguettecount");
                watercount = savedInstanceState.GetInt("watercount");
                royalcount = savedInstanceState.GetInt("royalcount");
                cokecount = savedInstanceState.GetInt("cokecount");
                c2count = savedInstanceState.GetInt("c2count");
                nesteacount = savedInstanceState.GetInt("nesteacount");
                carrotcakecount = savedInstanceState.GetInt("carrotcakecount");
                oreocakecount = savedInstanceState.GetInt("oreocakecount");
                cheesecakecount = savedInstanceState.GetInt("cheesecakecount");
                ubecakecount = savedInstanceState.GetInt("ubecakecount");
                chococakecount = savedInstanceState.GetInt("chococakecount");
                total = savedInstanceState.GetInt("total");

                // Update UI elements with the restored values
                textquantityc2.Text = c2count.ToString();
                textquantitycoke.Text = cokecount.ToString();
                textquantitynestea.Text = nesteacount.ToString();
                textquantityroyal.Text = royalcount.ToString();
                textquantitywater.Text = watercount.ToString();

                totaltxt.Text = total.ToString();
            }
            else
            {
                // Handle Intent data
                string jsonString = Intent.GetStringExtra("Current");
                if (jsonString != null)
                {
                    totalprice = JsonConvert.DeserializeObject<yeabro>(jsonString);
                    cheesecount = totalprice.txtqtycheese;
                    kwasoncount = totalprice.txtqtykwason;
                    spanishcount = totalprice.txtqtyspanish;
                    meatcount = totalprice.txtqtymeat;
                    ubecount = totalprice.txtqtyube;
                    baguettecount = totalprice.txtqtybaguette;
                    c2count = totalprice.txtqtyc2;
                    cokecount = totalprice.txtqtycoke;
                    watercount = totalprice.txtqtywater;
                    nesteacount = totalprice.txtqtynestea;
                    royalcount = totalprice.txtqtyroyal;
                    chococakecount = totalprice.txtqtychococake;
                    cheesecakecount = totalprice.txtqtycheesecake;
                    oreocakecount = totalprice.txtqtyoreocake;
                    carrotcakecount = totalprice.txtqtycarrotcake;
                    ubecakecount = totalprice.txtqtyubecake;

                    total = totalprice.totalp;

                    // Update UI elements with the restored values
                    textquantityc2.Text = c2count.ToString();
                    textquantitycoke.Text = cokecount.ToString();
                    textquantitynestea.Text = nesteacount.ToString();
                    textquantityroyal.Text = royalcount.ToString();
                    textquantitywater.Text = watercount.ToString();
                    totaltxt.Text = total.ToString();
                }
            }
        }
        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            outState.PutInt("cheesecount", cheesecount);
            outState.PutInt("kwasoncount", kwasoncount);
            outState.PutInt("spanishcount", spanishcount);
            outState.PutInt("meatcount", meatcount);
            outState.PutInt("ubecount", ubecount);
            outState.PutInt("baguettecount", baguettecount);
            outState.PutInt("watercount", watercount);
            outState.PutInt("royalcount", royalcount);
            outState.PutInt("c2count", c2count);
            outState.PutInt("cokecount", cokecount);
            outState.PutInt("nesteacount", nesteacount);
            outState.PutInt("carrotcakecount", carrotcakecount);
            outState.PutInt("chococakecount", chococakecount);
            outState.PutInt("oreocakecount", oreocakecount);
            outState.PutInt("ubecakecount", ubecakecount);
            outState.PutInt("cheesecakecount", cheesecakecount);
            outState.PutInt("total", total);
        }

        protected override void OnRestoreInstanceState(Bundle savedInstanceState)
        {
            base.OnRestoreInstanceState(savedInstanceState);
            cheesecount = savedInstanceState.GetInt("cheesecount");
            kwasoncount = savedInstanceState.GetInt("kwasoncount");
            spanishcount = savedInstanceState.GetInt("spanishcount");
            meatcount = savedInstanceState.GetInt("meatcount");
            ubecount = savedInstanceState.GetInt("ubecount");
            baguettecount = savedInstanceState.GetInt("baguettecount");
            watercount = savedInstanceState.GetInt("watercount");
            royalcount = savedInstanceState.GetInt("royalcount");
            cokecount = savedInstanceState.GetInt("cokecount");
            c2count = savedInstanceState.GetInt("c2count");
            nesteacount = savedInstanceState.GetInt("nesteacount");
            carrotcakecount = savedInstanceState.GetInt("carrotcakecount");
            chococakecount = savedInstanceState.GetInt("chococakecount");
            ubecakecount = savedInstanceState.GetInt("ubecakecount");
            cheesecakecount = savedInstanceState.GetInt("cheesecakecount");
            oreocakecount = savedInstanceState.GetInt("oreocakecount");

            total = savedInstanceState.GetInt("total");

            // Update UI elements with the restored values
            textquantityc2.Text = c2count.ToString();
            textquantitycoke.Text = cokecount.ToString();
            textquantitynestea.Text = nesteacount.ToString();
            textquantityroyal.Text = royalcount.ToString();
            textquantitywater.Text = watercount.ToString();


            totaltxt.Text = total.ToString();
        }

        private void Buttondone_Click(object sender, EventArgs e)
        {
            NavigateToActivity(typeof(RecieptActivity));
        }

        private void Plusnestea_Click(object sender, EventArgs e)
        {
            nesteacount++;
            int totnestea = nesteacount * 30;
            total += 30; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantitynestea.Text = $"{nesteacount}";
        }

        private void Minusnestea_Click(object sender, EventArgs e)
        {
            if (nesteacount > 0)
            {
                nesteacount--;
                int totnestea = c2count * 30;
                total -= 30; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantitynestea.Text = $"{nesteacount}";
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
            if (royalcount > 0)
            {
                royalcount--;
                int totroyal = royalcount * 25;
                total -= 25; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantityroyal.Text = $"{royalcount}";
        }

        private void Plusroyal_Click(object sender, EventArgs e)
        {
            royalcount++;
            int totroyal = royalcount * 25;
            total += 25; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantityroyal.Text = $"{royalcount}";
        }

        private void Minuswater_Click(object sender, EventArgs e)
        {
            if (watercount > 0)
            {
                watercount--;
                int totwater = watercount * 15;
                total -= 15; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantitywater.Text = $"{watercount}";
        }

        private void Pluswater_Click(object sender, EventArgs e)
        {
            watercount++;
            int totwater = watercount * 15;
            total += 15; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantitywater.Text = $"{watercount}";
        }

        private void Drinkbtn_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "You are already in the activity", ToastLength.Short).Show();
        }

        private void Cakebtn_Click(object sender, EventArgs e)
        {
            NavigateToActivity(typeof(CakeActivity));
        }

        private void Breadbtn_Click(object sender, EventArgs e)
        {
            NavigateToActivity(typeof(BreadActivity));
        }
        private void NavigateToActivity(Type activityType)
        {
            Intent intent = new Intent(this, activityType);

            yeabro yeabro = new yeabro()
            {
                txtqtymeat = meatcount,
                txtqtyube = ubecount,
                txtqtykwason = kwasoncount,
                txtqtybaguette = baguettecount,
                txtqtycheese = cheesecount,
                txtqtyspanish = spanishcount,
                txtqtywater = watercount,
                txtqtyroyal = royalcount,
                txtqtyc2 = c2count,
                txtqtycoke = cokecount,
                txtqtynestea = nesteacount,
                txtqtycarrotcake = carrotcakecount,
                txtqtycheesecake = cheesecakecount,
                txtqtychococake = chococakecount,
                txtqtyoreocake = oreocakecount,
                txtqtyubecake = ubecakecount,
                totalp = total
            };

            intent.PutExtra("Current", JsonConvert.SerializeObject(yeabro));

            StartActivity(intent);
        }
    }
}