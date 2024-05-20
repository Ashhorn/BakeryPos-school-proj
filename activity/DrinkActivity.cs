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
        TextView totaltxt,textquantitywater,textquantityroyal,textquantityc2,textquantitycoke,textquantitynestea,waterstock,nesteastock,c2stock,royalstock,cokestock;
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
            nesteastock = FindViewById<TextView>(Resource.Id.nesteastock);
            waterstock = FindViewById<TextView>(Resource.Id.waterstock);
            c2stock = FindViewById<TextView>(Resource.Id.c2stock);
            cokestock = FindViewById<TextView>(Resource.Id.cokestock);
            royalstock = FindViewById<TextView>(Resource.Id.royalstock);


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
                    textquantityc2.Text = c2count.ToString();
                    textquantitycoke.Text = cokecount.ToString();
                    textquantitynestea.Text = nesteacount.ToString();
                    textquantityroyal.Text = royalcount.ToString();
                    textquantitywater.Text = watercount.ToString();
                    waterstock.Text = stockwater.ToString();
                    c2stock.Text = stockc2.ToString();
                    royalstock.Text = stockroyal.ToString();
                    cokestock.Text = stockcoke.ToString();
                    nesteastock.Text = stocknestea.ToString();

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
            if (stocknestea > 0) // Check if there's stock available
            {
                nesteacount++;
                total += 30;
                totaltxt.Text = total.ToString();
                stocknestea--; // Decrease stock when a baguette is added
                nesteastock.Text = $"{stocknestea}";
            }
            else
            {
                Toast.MakeText(this, "No more nestea in stock", ToastLength.Short).Show();
            }
            textquantitynestea.Text = $"{nesteacount}";
        }

        private void Minusnestea_Click(object sender, EventArgs e)
        {
            if (nesteacount > 0)
            {
                nesteacount--;
                total -= 30;
                totaltxt.Text = total.ToString();
                stocknestea++; // Increase stock when a baguette is removed
                nesteastock.Text = $"{stocknestea}";
            }
            textquantitynestea.Text = $"{nesteacount}";
        }

        private void Minuscoke_Click(object sender, EventArgs e)
        {
            if (cokecount > 0)
            {
                cokecount--;
                total -= 25;
                totaltxt.Text = total.ToString();
                stockcoke++; // Increase stock when a baguette is removed
                cokestock.Text = $"{stockcoke}";
            }
            textquantitycoke.Text = $"{cokecount}";
        }

        private void Pluscoke_Click(object sender, EventArgs e)
        {
            if (stockcoke > 0) // Check if there's stock available
            {
                cokecount++;
                total += 25;
                totaltxt.Text = total.ToString();
                stockcoke--; // Decrease stock when a baguette is added
                cokestock.Text = $"{stockcoke}";
            }
            else
            {
                Toast.MakeText(this, "No more coke in stock", ToastLength.Short).Show();
            }
            textquantitycoke.Text = $"{cokecount}";
        }

        private void Minusc2_Click(object sender, EventArgs e)
        {
            if (c2count > 0)
            {
                c2count--;
                total -= 25;
                totaltxt.Text = total.ToString();
                stockc2++; // Increase stock when a baguette is removed
                c2stock.Text = $"{stockc2}";
            }
            textquantityc2.Text = $"{c2count}";
        }

        private void Plusc2_Click(object sender, EventArgs e)
        {
            if (stockc2 > 0) // Check if there's stock available
            {
                c2count++;
                total += 25;
                totaltxt.Text = total.ToString();
                stockc2--; // Decrease stock when a baguette is added
                c2stock.Text = $"{stockc2}";
            }
            else
            {
                Toast.MakeText(this, "No more c2 in stock", ToastLength.Short).Show();
            }
            textquantityc2.Text = $"{c2count}";
        }

        private void Minusroyal_Click(object sender, EventArgs e)
        {
            if (royalcount > 0)
            {
                royalcount--;
                total -= 25;
                totaltxt.Text = total.ToString();
                stockroyal++; // Increase stock when a baguette is removed
                royalstock.Text = $"{stockroyal}";
            }
            textquantityroyal.Text = $"{royalcount}";
        }

        private void Plusroyal_Click(object sender, EventArgs e)
        {
            if (stockroyal > 0) // Check if there's stock available
            {
                royalcount++;
                total += 25;
                totaltxt.Text = total.ToString();
                stockroyal--; // Decrease stock when a baguette is added
                royalstock.Text = $"{stockroyal}";
            }
            else
            {
                Toast.MakeText(this, "No more royal in stock", ToastLength.Short).Show();
            }
            textquantityroyal.Text = $"{royalcount}";
        }

        private void Minuswater_Click(object sender, EventArgs e)
        {
            if (watercount > 0)
            {
                watercount--;
                total -= 15;
                totaltxt.Text = total.ToString();
                stockwater++; // Increase stock when a baguette is removed
                waterstock.Text = $"{stockwater}";
            }
            textquantitywater.Text = $"{watercount}";
        }

        private void Pluswater_Click(object sender, EventArgs e)
        {
            if (stockwater > 0) // Check if there's stock available
            {
                watercount++;
                total += 15;
                totaltxt.Text = total.ToString();
                stockwater--; // Decrease stock when a baguette is added
                waterstock.Text = $"{stockwater}";
            }
            else
            {
                Toast.MakeText(this, "No more water in stock", ToastLength.Short).Show();
            }
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