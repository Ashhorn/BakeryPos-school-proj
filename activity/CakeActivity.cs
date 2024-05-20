using Android.Accounts;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wtf.activity
{
    [Activity(Label = "CakeActivity")]
    public class CakeActivity : Activity
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
        TextView totaltxt, textquantitycheesec,textquantityubec,textquantityoreoc,textquantitycarrotc,textquantitychocolatec,oreocakestock,cheesecakestock,carrotcakestock,chococakestock,ubecakestock;
        yeabro totalprice;
        Button breadbtn, cakebtn, drinkbtn, pluscheesec,minuscheesec,plusubec,minusubec,plusoreoc,minusoreoc,pluscarrotc,minuscarrotc,pluschocolatec,minuschocolatec,buttondone;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CakeLayout);
            buttondone = FindViewById<Button>(Resource.Id.buttonDone);
            breadbtn = FindViewById<Button>(Resource.Id.button1);
            cakebtn = FindViewById<Button>(Resource.Id.button2);
            drinkbtn = FindViewById<Button>(Resource.Id.button3);
            totaltxt = FindViewById<TextView>(Resource.Id.totaltxt);
            textquantitycheesec = FindViewById<TextView>(Resource.Id.textquantitycheesecake);
            pluscheesec = FindViewById<Button>(Resource.Id.pluscheesecake);
            minuscheesec = FindViewById<Button>(Resource.Id.minuscheesecake);
            textquantityubec = FindViewById<TextView>(Resource.Id.textquantityubecake);
            plusubec = FindViewById<Button>(Resource.Id.plusubecake);
            minusubec = FindViewById<Button>(Resource.Id.minusubecake);
            textquantityoreoc = FindViewById<TextView>(Resource.Id.textquantityoreocake);
            minusoreoc = FindViewById<Button>(Resource.Id.minusoreocake);
            plusoreoc = FindViewById<Button>(Resource.Id.plusoreocake);
            textquantitycarrotc = FindViewById<TextView>(Resource.Id.textquantitycarrotcake);
            pluscarrotc = FindViewById<Button>(Resource.Id.pluscarrotcake);
            minuscarrotc = FindViewById<Button>(Resource.Id.minuscarrotcake);
            textquantitychocolatec = FindViewById<TextView>(Resource.Id.textquantitychococake);
            pluschocolatec = FindViewById<Button>(Resource.Id.pluschococake);
            minuschocolatec = FindViewById<Button>(Resource.Id.minuschococake);
            oreocakestock = FindViewById<TextView>(Resource.Id.oreocakestock);
            cheesecakestock = FindViewById<TextView>(Resource.Id.cheesecakestock);
            ubecakestock = FindViewById<TextView>(Resource.Id.ubecakestock);
            chococakestock = FindViewById<TextView>(Resource.Id.chococakestock);
            carrotcakestock = FindViewById<TextView>(Resource.Id.carrotcakestock);

            buttondone.Click += Buttondone_Click;
            pluscheesec.Click += Pluscheesec_Click;
            minuscheesec.Click += Minuscheesec_Click;
            plusubec.Click += Plusubec_Click;
            minusubec.Click += Minusubec_Click;
            plusoreoc.Click += Plusoreoc_Click;
            minusoreoc.Click += Minusoreoc_Click;
            pluscarrotc.Click += Pluscarrotc_Click;
            minuscarrotc.Click += Minuscarrotc_Click;
            pluschocolatec.Click += Pluschocolatec_Click;
            minuschocolatec.Click += Minuschocolatec_Click;
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
                textquantitycarrotc.Text = carrotcakecount.ToString();
                textquantitycheesec.Text = cheesecakecount.ToString();
                textquantityubec.Text = ubecakecount.ToString();
                textquantitychocolatec.Text = chococakecount.ToString();
                textquantityoreoc.Text = oreocakecount.ToString();

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
                    textquantitycarrotc.Text = carrotcakecount.ToString();
                    textquantitycheesec.Text = cheesecakecount.ToString();
                    textquantityubec.Text = ubecakecount.ToString();
                    textquantitychocolatec.Text = chococakecount.ToString();
                    textquantityoreoc.Text = oreocakecount.ToString();
                    oreocakestock.Text = stockoreocake.ToString();
                    carrotcakestock.Text = stockcarrotcake.ToString();
                    chococakestock.Text = stockchococake.ToString();
                    ubecakestock.Text = stockubecake.ToString();
                    cheesecakestock.Text = stockcheesecake.ToString();

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
            textquantitycarrotc.Text = carrotcakecount.ToString();
            textquantitycheesec.Text = cheesecakecount.ToString();
            textquantityubec.Text = ubecakecount.ToString();
            textquantitychocolatec.Text = chococakecount.ToString();
            textquantityoreoc.Text = oreocakecount.ToString();


            totaltxt.Text = total.ToString();
        }

        private void Buttondone_Click(object sender, EventArgs e)
        {
            NavigateToActivity(typeof(RecieptActivity));
        }

        private void Minuschocolatec_Click(object sender, EventArgs e)
        {
            if (chococakecount > 0)
            {
                chococakecount--;
                total -= 200;
                totaltxt.Text = total.ToString();
                stockchococake++; // Increase stock when a baguette is removed
                chococakestock.Text = $"{stockchococake}";
            }
            textquantitychocolatec.Text = $"{chococakecount}";
        }

        private void Pluschocolatec_Click(object sender, EventArgs e)
        {
            if (stockchococake > 0) // Check if there's stock available
            {
                chococakecount++;
                total += 200;
                totaltxt.Text = total.ToString();
                stockchococake--; // Decrease stock when a baguette is added
                chococakestock.Text = $"{stockchococake}";
            }
            else
            {
                Toast.MakeText(this, "No more chocolate cake in stock", ToastLength.Short).Show();
            }
            textquantitychocolatec.Text = $"{chococakecount}";
        }

        private void Minuscarrotc_Click(object sender, EventArgs e)
        {
            if (carrotcakecount > 0)
            {
                carrotcakecount--;
                total -= 200;
                totaltxt.Text = total.ToString();
                stockcarrotcake++; // Increase stock when a baguette is removed
                carrotcakestock.Text = $"{stockcarrotcake}";
            }
            textquantitycarrotc.Text = $"{carrotcakecount}";
        }

        private void Pluscarrotc_Click(object sender, EventArgs e)
        {
            if (stockcarrotcake > 0) // Check if there's stock available
            {
                carrotcakecount++;
                total += 200;
                totaltxt.Text = total.ToString();
                stockcarrotcake--; // Decrease stock when a baguette is added
                carrotcakestock.Text = $"{stockcarrotcake}";
            }
            else
            {
                Toast.MakeText(this, "No more carrot cake in stock", ToastLength.Short).Show();
            }
            textquantitycarrotc.Text = $"{carrotcakecount}";
        }

        private void Minusoreoc_Click(object sender, EventArgs e)
        {
            if (oreocakecount > 0)
            {
                oreocakecount--;
                total -= 200;
                totaltxt.Text = total.ToString();
                stockoreocake++; // Increase stock when a baguette is removed
                oreocakestock.Text = $"{stockoreocake}";
            }
            textquantityoreoc.Text = $"{oreocakecount}";
        }

        private void Plusoreoc_Click(object sender, EventArgs e)
        {
            if (stockoreocake > 0) // Check if there's stock available
            {
                oreocakecount++;
                total += 200;
                totaltxt.Text = total.ToString();
                stockoreocake--; // Decrease stock when a baguette is added
                oreocakestock.Text = $"{stockoreocake}";
            }
            else
            {
                Toast.MakeText(this, "No more oreo cake in stock", ToastLength.Short).Show();
            }
            textquantityoreoc.Text = $"{oreocakecount}";
        }

        private void Minusubec_Click(object sender, EventArgs e)
        {
            if (ubecakecount > 0)
            {
                ubecakecount--;
                total -= 200;
                totaltxt.Text = total.ToString();
                stockubecake++; // Increase stock when a baguette is removed
                ubecakestock.Text = $"{stockubecake}";
            }
            textquantityubec.Text = $"{ubecakecount}";
        }

        private void Plusubec_Click(object sender, EventArgs e)
        {
            if (stockubecake > 0) // Check if there's stock available
            {
                ubecakecount++;
                total += 200;
                totaltxt.Text = total.ToString();
                stockubecake--; // Decrease stock when a baguette is added
                ubecakestock.Text = $"{stockubecake}";
            }
            else
            {
                Toast.MakeText(this, "No more ube cake in stock", ToastLength.Short).Show();
            }
            textquantityubec.Text = $"{ubecakecount}";
        }

        private void Minuscheesec_Click(object sender, EventArgs e)
        {
            if (cheesecakecount > 0)
            {
                cheesecakecount--;
                total -= 200;
                totaltxt.Text = total.ToString();
                stockcheesecake++; // Increase stock when a baguette is removed
                cheesecakestock.Text = $"{stockcheesecake}";
            }
            textquantitycheesec.Text = $"{cheesecakecount}";
        }

        private void Pluscheesec_Click(object sender, EventArgs e)
        {
            if (stockcheesecake > 0) // Check if there's stock available
            {
                cheesecakecount++;
                total += 200;
                totaltxt.Text = total.ToString();
                stockcheesecake--; // Decrease stock when a baguette is added
                cheesecakestock.Text = $"{stockcheesecake}";
            }
            else
            {
                Toast.MakeText(this, "No more cheese cake in stock", ToastLength.Short).Show();
            }
            textquantitycheesec.Text = $"{cheesecakecount}";
        }

        private void Drinkbtn_Click(object sender, EventArgs e)
        {
            NavigateToActivity(typeof(DrinkActivity));
        }

        private void Cakebtn_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "You are already in the activity", ToastLength.Short).Show();
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