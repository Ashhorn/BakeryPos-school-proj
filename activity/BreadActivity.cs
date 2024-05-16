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
        yeabro totalprice, txtbaguette;
        TextView textquantitybaguette, totaltxt,textquantitycheese,textquantitymeat,textquantitykwason,textquantityube,textquantityspanish;
        Button breadbtn, cakebtn, drinkbtn, plusbagguete, minusbagguete, pluscheese, minuscheese,plusube, minusube,pluskwason, minuskwason, plusmeat, minusmeat, plusspanish, minusspanish,buttondone;
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
            buttondone = FindViewById<Button>(Resource.Id.buttonDone);
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

            buttondone.Click += Buttondone_Click;
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
                textquantitycheese.Text = cheesecount.ToString();
                textquantitykwason.Text = kwasoncount.ToString();
                textquantityspanish.Text = spanishcount.ToString();
                textquantitymeat.Text = meatcount.ToString();
                textquantityube.Text = ubecount.ToString();
                textquantitybaguette.Text = baguettecount.ToString();
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
                    textquantitycheese.Text = cheesecount.ToString();
                    textquantitykwason.Text = kwasoncount.ToString();
                    textquantityspanish.Text = spanishcount.ToString();
                    textquantitymeat.Text = meatcount.ToString();
                    textquantityube.Text = ubecount.ToString();
                    textquantitybaguette.Text = baguettecount.ToString();
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
            textquantitycheese.Text = cheesecount.ToString();
            textquantitykwason.Text = kwasoncount.ToString();
            textquantityspanish.Text = spanishcount.ToString();
            textquantitymeat.Text = meatcount.ToString();
            textquantityube.Text = ubecount.ToString();
            textquantitybaguette.Text = baguettecount.ToString();

            totaltxt.Text = total.ToString();
        }
        private void Buttondone_Click(object sender, EventArgs e)
        {
            NavigateToActivity(typeof(RecieptActivity));
        }

        private void Minusspanish_Click(object sender, EventArgs e)
        {
            if (spanishcount > 0)
            {
                spanishcount--;
                int totcheese = spanishcount * 5;
                total -= 5; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantityspanish.Text = $"{spanishcount}";
        }

        private void Plusspanish_Click(object sender, EventArgs e)
        {
            spanishcount++;
            int totcheese = spanishcount * 5;
            total += 5; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantityspanish.Text = $"{spanishcount}";
        }

        private void Minuskwason_Click(object sender, EventArgs e)
        {
            if (kwasoncount > 0)
            {
                kwasoncount--;
                int totcheese = kwasoncount * 10;
                total -= 10; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantitykwason.Text = $"{kwasoncount}";
        }

        private void Pluskwason_Click(object sender, EventArgs e)
        {
            kwasoncount++;
            int totcheese = kwasoncount * 10;
            total += 10; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantitykwason.Text = $"{kwasoncount}";
        }

        private void Minusmeat_Click(object sender, EventArgs e)
        {
            if (meatcount > 0)
            {
                meatcount--;
                int totcheese = meatcount * 15;
                total -= 15; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantitymeat.Text = $"{meatcount}";
        }

        private void Plusmeat_Click(object sender, EventArgs e)
        {
            meatcount++;
            int totcheese = meatcount * 15;
            total += 15; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantitymeat.Text = $"{meatcount}";
        }

        private void Minusube_Click(object sender, EventArgs e)
        {
            if (ubecount > 0)
            {
                ubecount--;
                int totcheese = ubecount * 10;
                total -= 10; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantityube.Text = $"{ubecount}";
        }

        private void Plusube_Click(object sender, EventArgs e)
        {
            ubecount++;
            int totcheese = ubecount * 10;
            total += 10; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantityube.Text = $"{ubecount}";
        }

        private void Minuscheese_Click(object sender, EventArgs e)
        {
            if (cheesecount > 0)
            {
                cheesecount--;
                int totcheese = cheesecount * 7;
                total -= 7; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantitycheese.Text = $"{cheesecount}";
        }

        private void Pluscheese_Click(object sender, EventArgs e)
        {
            cheesecount++;
            int totcheese = cheesecount * 7;
            total += 7; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantitycheese.Text = $"{cheesecount}";
        }

        public void Minusbagguete_Click(object sender, EventArgs e)
        {
            if (baguettecount > 0)
            {
                baguettecount--;
                int totbaguette = baguettecount * 75;
                total -= 75; // Subtract the price of one baguette
                totaltxt.Text = total.ToString();
            }
            textquantitybaguette.Text = $"{baguettecount}";
        }


        public void Plusbagguete_Click(object sender, EventArgs e)
        {
            baguettecount++;
            int totbaguette = baguettecount * 75;
            total += 75; // Add the price of one baguette
            totaltxt.Text = total.ToString();
            textquantitybaguette.Text = $"{baguettecount}";
        }

        private void Drinkbtn_Click(object sender, EventArgs e)
        {
            NavigateToActivity(typeof(DrinkActivity));
        }

        private void Cakebtn_Click(object sender, EventArgs e)
        {
            NavigateToActivity(typeof(CakeActivity));
        }

        private void Breadbtn_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "You are already in the activity", ToastLength.Short).Show();
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