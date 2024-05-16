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
        int total = 0;
        TextView totaltxt, textquantitycheesec,textquantityubec,textquantityoreoc,textquantitycarrotc,textquantitychocolatec;
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

                    total = totalprice.totalp;

                    // Update UI elements with the restored values
                    textquantitycarrotc.Text = carrotcakecount.ToString();
                    textquantitycheesec.Text = cheesecakecount.ToString();
                    textquantityubec.Text = ubecakecount.ToString();
                    textquantitychocolatec.Text = chococakecount.ToString();
                    textquantityoreoc.Text = oreocakecount.ToString();
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
                int totcheese = chococakecount * 200;
                total -= 200; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantitychocolatec.Text = $"{chococakecount}";
        }

        private void Pluschocolatec_Click(object sender, EventArgs e)
        {
            chococakecount++;
            int totcheese = chococakecount * 200;
            total += 200; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantitychocolatec.Text = $"{chococakecount}";
        }

        private void Minuscarrotc_Click(object sender, EventArgs e)
        {
            if (carrotcakecount > 0)
            {
                carrotcakecount--;
                int totcheese = carrotcakecount * 200;
                total -= 200; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantitycarrotc.Text = $"{carrotcakecount}";
        }

        private void Pluscarrotc_Click(object sender, EventArgs e)
        {
            carrotcakecount++;
            int totcheese = carrotcakecount * 200;
            total += 200; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantitycarrotc.Text = $"{carrotcakecount}";
        }
        private void Minusoreoc_Click(object sender, EventArgs e)
        {
            if (oreocakecount > 0)
            {
                oreocakecount--;
                int totcheese = oreocakecount * 200;
                total -= 200; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantityoreoc.Text = $"{oreocakecount}";
        }

        private void Plusoreoc_Click(object sender, EventArgs e)
        {
            oreocakecount++;
            int totcheese = oreocakecount * 200;
            total += 200; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantityoreoc.Text = $"{oreocakecount}";
        }

        private void Minusubec_Click(object sender, EventArgs e)
        {
            if (ubecakecount > 0)
            {
                ubecakecount--;
                int totcheese = ubecakecount * 200;
                total -= 200; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantityubec.Text = $"{ubecakecount}";
        }

        private void Plusubec_Click(object sender, EventArgs e)
        {
            ubecakecount++;
            int totcheese = ubecakecount * 200;
            total += 200; // Add the price of one cheese
            totaltxt.Text = total.ToString();
            textquantityubec.Text = $"{ubecakecount}";
        }

        private void Minuscheesec_Click(object sender, EventArgs e)
        {
            if (cheesecakecount > 0)
            {
                cheesecakecount--;
                int totcheese = cheesecakecount * 200;
                total -= 200; // Subtract the price of one cheese
                totaltxt.Text = total.ToString();
            }
            textquantitycheesec.Text = $"{cheesecakecount}";
        }

        private void Pluscheesec_Click(object sender, EventArgs e)
        {
            cheesecakecount++;
            int totcheese = cheesecakecount * 200;
            total += 200; // Add the price of one cheese
            totaltxt.Text = total.ToString();
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
                totalp = total
            };

            intent.PutExtra("Current", JsonConvert.SerializeObject(yeabro));

            StartActivity(intent);
        }
    }
}