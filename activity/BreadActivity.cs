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
        int stockBaguette = 10;
        int stockKwason = 7;
        int stockSpanish = 15;
        int stockUbe = 5;
        int stockMeat = 8;
        int stockCheese = 4;
        int stockcheesecake = 5;
        int stockubecake = 3;
        int stockoreocake = 3;
        int stockcarrotcake = 2;
        int stockchococake = 6;
        int stockwater = 12;
        int stockroyal = 13;
        int stockcoke = 8;
        int stocknestea = 10;
        int stockc2 = 6;
        int total = 0;
        yeabro totalprice, txtbaguette;
        TextView textquantitybaguette, totaltxt,textquantitycheese,textquantitymeat,textquantitykwason,textquantityube,textquantityspanish,ubestock,spanishstock,meatstock,cheesestock,kwasonstock,baguettestock;
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
            ubestock = FindViewById<TextView>(Resource.Id.ubestock);
            baguettestock = FindViewById<TextView>(Resource.Id.baguettestock);
            meatstock = FindViewById<TextView>(Resource.Id.meatstock);
            kwasonstock = FindViewById<TextView>(Resource.Id.kwasonstock);
            cheesestock = FindViewById<TextView>(Resource.Id.cheesestock);
            spanishstock = FindViewById<TextView>(Resource.Id.spanishstock);

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
                stockBaguette = savedInstanceState.GetInt("stockbaguette");
                stockMeat = savedInstanceState.GetInt("stockmeat");
                stockCheese = savedInstanceState.GetInt("stockcheese");
                stockKwason = savedInstanceState.GetInt("stockkwason");
                stockUbe = savedInstanceState.GetInt("stockube");
                stockSpanish = savedInstanceState.GetInt("stockspanish");
                stockc2 = savedInstanceState.GetInt("stockc2");
                stockcoke = savedInstanceState.GetInt("stockcoke");
                stocknestea = savedInstanceState.GetInt("stocknestea");
                stockroyal = savedInstanceState.GetInt("stockroyal");
                stockwater = savedInstanceState.GetInt("stockwater");
                stockcheesecake = savedInstanceState.GetInt("stockcheesecake");
                stockubecake = savedInstanceState.GetInt("stockubecake");
                stockchococake = savedInstanceState.GetInt("stockchococake");
                stockoreocake = savedInstanceState.GetInt("stockoreocake");
                stockcarrotcake = savedInstanceState.GetInt("stockcarrotcake");
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
                    stockBaguette -= baguettecount;
                    stockMeat -= meatcount;
                    stockCheese -= cheesecount;
                    stockKwason -= kwasoncount;
                    stockSpanish -= spanishcount;
                    stockUbe -= ubecount;
                    stockc2 -= c2count;
                    stockwater -= watercount;
                    stockroyal -= royalcount;
                    stockcoke -= cokecount;
                    stocknestea -= nesteacount;
                    stockchococake -= chococakecount;
                    stockcheesecake -= cheesecakecount;
                    stockubecake -= ubecakecount;
                    stockoreocake -= oreocakecount;
                    stockcarrotcake -= carrotcakecount;

                    total = totalprice.totalp;

                    // Update UI elements with the restored values
                    textquantitycheese.Text = cheesecount.ToString();
                    textquantitykwason.Text = kwasoncount.ToString();
                    textquantityspanish.Text = spanishcount.ToString();
                    textquantitymeat.Text = meatcount.ToString();
                    textquantityube.Text = ubecount.ToString();
                    textquantitybaguette.Text = baguettecount.ToString();
                    baguettestock.Text = stockBaguette.ToString();
                    meatstock.Text = stockMeat.ToString();
                    kwasonstock.Text = stockKwason.ToString();
                    ubestock.Text = stockUbe.ToString();
                    spanishstock.Text = stockSpanish.ToString();
                    cheesestock.Text = stockCheese.ToString();

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
            outState.PutInt("stockbaguette", stockBaguette);
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
            stockBaguette = savedInstanceState.GetInt("stockbaguette");

            total = savedInstanceState.GetInt("total");

            // Update UI elements with the restored values
            textquantitycheese.Text = cheesecount.ToString();
            textquantitykwason.Text = kwasoncount.ToString();
            textquantityspanish.Text = spanishcount.ToString();
            textquantitymeat.Text = meatcount.ToString();
            textquantityube.Text = ubecount.ToString();
            textquantitybaguette.Text = baguettecount.ToString();
            baguettestock.Text = stockBaguette.ToString();

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
                total -= 5;
                totaltxt.Text = total.ToString();
                stockSpanish++; // Increase stock when a baguette is removed
                spanishstock.Text = $"{stockSpanish}";
            }
            textquantityspanish.Text = $"{spanishcount}";
        }

        private void Plusspanish_Click(object sender, EventArgs e)
        {
            if (stockSpanish > 0) // Check if there's stock available
            {
                spanishcount++;
                total += 5;
                totaltxt.Text = total.ToString();
                stockSpanish--; // Decrease stock when a baguette is added
                spanishstock.Text = $"{stockSpanish}";
            }
            else
            {
                Toast.MakeText(this, "No more spanish bread in stock", ToastLength.Short).Show();
            }
            textquantityspanish.Text = $"{spanishcount}";
        }

        private void Minuskwason_Click(object sender, EventArgs e)
        {
            if (kwasoncount > 0)
            {
                kwasoncount--;
                total -= 10;
                totaltxt.Text = total.ToString();
                stockKwason++; // Increase stock when a baguette is removed
                kwasonstock.Text = $"{stockKwason}";
            }
            textquantitykwason.Text = $"{kwasoncount}";
        }

        private void Pluskwason_Click(object sender, EventArgs e)
        {
            if (stockKwason > 0) // Check if there's stock available
            {
                kwasoncount++;
                total += 10;
                totaltxt.Text = total.ToString();
                stockKwason--; // Decrease stock when a baguette is added
                kwasonstock.Text = $"{stockKwason}";
            }
            else
            {
                Toast.MakeText(this, "No more kwason in stock", ToastLength.Short).Show();
            }
            textquantitykwason.Text = $"{kwasoncount}";
        }

        private void Minusmeat_Click(object sender, EventArgs e)
        {
            if (meatcount > 0)
            {
                meatcount--;
                total -= 15;
                totaltxt.Text = total.ToString();
                stockMeat++; // Increase stock when a baguette is removed
                meatstock.Text = $"{stockMeat}";
            }
            textquantitymeat.Text = $"{meatcount}";
        }

        private void Plusmeat_Click(object sender, EventArgs e)
        {
            if (stockMeat > 0) // Check if there's stock available
            {
                meatcount++;
                total += 15;
                totaltxt.Text = total.ToString();
                stockMeat--; // Decrease stock when a baguette is added
                meatstock.Text = $"{stockMeat}";
            }
            else
            {
                Toast.MakeText(this, "No more meat roll in stock", ToastLength.Short).Show();
            }
            textquantitymeat.Text = $"{meatcount}";
        }

        private void Minusube_Click(object sender, EventArgs e)
        {
            if (ubecount > 0)
            {
                ubecount--;
                total -= 10;
                totaltxt.Text = total.ToString();
                stockUbe++; // Increase stock when a baguette is removed
                ubestock.Text = $"{stockUbe}";
            }
            textquantityube.Text = $"{ubecount}";
        }

        private void Plusube_Click(object sender, EventArgs e)
        {
            if (stockUbe > 0) // Check if there's stock available
            {
                ubecount++;
                total += 10;
                totaltxt.Text = total.ToString();
                stockUbe--; // Decrease stock when a baguette is added
                ubestock.Text = $"{stockUbe}";
            }
            else
            {
                Toast.MakeText(this, "No more ube pandesal in stock", ToastLength.Short).Show();
            }
            textquantityube.Text = $"{ubecount}";
        }

        private void Minuscheese_Click(object sender, EventArgs e)
        {
            if (cheesecount > 0)
            {
                cheesecount--;
                total -= 7;
                totaltxt.Text = total.ToString();
                stockCheese++; // Increase stock when a baguette is removed
                cheesestock.Text = $"{stockCheese}";
            }
            textquantitycheese.Text = $"{cheesecount}";
        }

        private void Pluscheese_Click(object sender, EventArgs e)
        {
            if (stockCheese > 0) // Check if there's stock available
            {
                cheesecount++;
                total += 7;
                totaltxt.Text = total.ToString();
                stockCheese--; // Decrease stock when a baguette is added
                cheesestock.Text = $"{stockCheese}";
            }
            else
            {
                Toast.MakeText(this, "No more cheese bread in stock", ToastLength.Short).Show();
            }
            textquantitycheese.Text = $"{cheesecount}";
        }

        public void Minusbagguete_Click(object sender, EventArgs e)
        {
            if (baguettecount > 0)
            {
                baguettecount--;
                total -= 75;
                totaltxt.Text = total.ToString();
                stockBaguette++; // Increase stock when a baguette is removed
                baguettestock.Text = $"{stockBaguette}";
            }
            textquantitybaguette.Text = $"{baguettecount}";
        }


        public void Plusbagguete_Click(object sender, EventArgs e)
        {
            if (stockBaguette > 0) // Check if there's stock available
            {
                baguettecount++;
                total += 75;
                totaltxt.Text = total.ToString();
                stockBaguette--; // Decrease stock when a baguette is added
                baguettestock.Text = $"{stockBaguette}";
            }
            else
            {
                Toast.MakeText(this, "No more baguettes in stock", ToastLength.Short).Show();
            }
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

                txtstockbaguette = stockBaguette,
                txtstockcheese = stockCheese,
                txtstockkwason = stockKwason,
                txtstockube = stockUbe,
                txtstockspanish = stockSpanish,
                txtstockmeat = stockMeat,
                txtstockwater = stockwater,
                txtstockc2 = stockc2,
                txtstockroyal = stockroyal,
                txtstockcoke = stockcoke,
                txtstocknestea = stocknestea,
                txtstockcheesecake = stockcheesecake,
                txtstockcarrotcake = stockcarrotcake,
                txtstockchococake = stockchococake,
                txtstockoreocake = stockoreocake,
                txtstockubecake = stockubecake,
                totalp = total
            };

            intent.PutExtra("Current", JsonConvert.SerializeObject(yeabro));

            StartActivity(intent);
        }
    }
}