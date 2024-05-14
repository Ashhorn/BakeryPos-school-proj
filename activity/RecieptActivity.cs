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
    [Activity(Label = "RecieptActivity")]
    public class RecieptActivity : Activity
    {
        int cheesecount = 0;
        int kwasoncount = 0;
        int spanishcount = 0;
        int meatcount = 0;
        int ubecount = 0;
        int baguettecount = 0;
        int total = 0;
        yeabro totalprice;
        Button button1, button2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Retrieve the JSON string from the Intent extras
            SetContentView(Resource.Layout.RecieptLayout);
            string jsonString = Intent.GetStringExtra("Current");

            if (!string.IsNullOrEmpty(jsonString))
            {
                // Deserialize the JSON string back to a yeabro object
                yeabro receiptData = JsonConvert.DeserializeObject<yeabro>(jsonString);

                // Find UI elements
                TextView txtMeatQty = FindViewById<TextView>(Resource.Id.txtMeatQty);
                TextView txtUbeQty = FindViewById<TextView>(Resource.Id.txtUbeQty);
                TextView txtKwasonQty = FindViewById<TextView>(Resource.Id.txtKwasonQty);
                TextView txtBaguetteQty = FindViewById<TextView>(Resource.Id.txtBaguetteQty);
                TextView txtCheeseQty = FindViewById<TextView>(Resource.Id.txtCheeseQty);
                TextView txtSpanishQty = FindViewById<TextView>(Resource.Id.txtSpanishQty);
                TextView txtTotalPrice = FindViewById<TextView>(Resource.Id.txtTotalPrice);
                TextView txtCarrotCakeQty = FindViewById<TextView>(Resource.Id.txtCarrotCakeQty);
                TextView txtOreoCakeQty = FindViewById<TextView>(Resource.Id.txtOreoCakeQty);
                TextView txtCheeseCakeQty = FindViewById<TextView>(Resource.Id.txtCheeseCakeQty);
                TextView txtUbeCakeQty = FindViewById<TextView>(Resource.Id.txtUbeCakeQty);
                TextView txtChocoCakeQty = FindViewById<TextView>(Resource.Id.txtChocoCakeQty);
                TextView txtWaterQty = FindViewById<TextView>(Resource.Id.txtWaterQty);
                TextView txtRoyalQty = FindViewById<TextView>(Resource.Id.txtRoyalQty);
                TextView txtNesteaQty = FindViewById<TextView>(Resource.Id.txtNesteaQty);
                TextView txtC2Qty = FindViewById<TextView>(Resource.Id.txtC2Qty);
                TextView txtCokeQty = FindViewById<TextView>(Resource.Id.txtCokeQty);

                // Check and set visibility based on actual data
                if (receiptData.txtqtymeat > 0)
                {
                    txtMeatQty.Text = $"Meat Quantity: {receiptData.txtqtymeat}";
                    txtMeatQty.Visibility = ViewStates.Visible;
                }

                if (receiptData.txtqtyube > 0)
                {
                    txtUbeQty.Text = $"Ube Quantity: {receiptData.txtqtyube}";
                    txtUbeQty.Visibility = ViewStates.Visible;
                }

                if (receiptData.txtqtykwason > 0)
                {
                    txtKwasonQty.Text = $"Kwason Quantity: {receiptData.txtqtykwason}";
                    txtKwasonQty.Visibility = ViewStates.Visible;
                }

                if (receiptData.txtqtybaguette > 0)
                {
                    txtBaguetteQty.Text = $"Baguette Quantity: {receiptData.txtqtybaguette}";
                    txtBaguetteQty.Visibility = ViewStates.Visible;
                }

                if (receiptData.txtqtycheese > 0)
                {
                    txtCheeseQty.Text = $"Cheese Quantity: {receiptData.txtqtycheese}";
                    txtCheeseQty.Visibility = ViewStates.Visible;
                }

                if (receiptData.txtqtyspanish > 0)
                {
                    txtSpanishQty.Text = $"Spanish Quantity: {receiptData.txtqtyspanish}";
                    txtSpanishQty.Visibility = ViewStates.Visible;
                }

                if (receiptData.txtqtywater > 0)
                {
                    txtWaterQty.Text = $"Water Quantity: {receiptData.txtqtywater}";
                    txtWaterQty.Visibility = ViewStates.Visible;
                }

                if (receiptData.txtqtyroyal > 0)
                {
                    txtRoyalQty.Text = $"Royal Quantity: {receiptData.txtqtyroyal}";
                    txtRoyalQty.Visibility = ViewStates.Visible;
                }

                if (receiptData.txtqtynestea > 0)
                {
                    txtNesteaQty.Text = $"Nestea Quantity: {receiptData.txtqtynestea}";
                    txtNesteaQty.Visibility = ViewStates.Visible;
                }

                if (receiptData.txtqtyc2 > 0)
                {
                    txtC2Qty.Text = $"C2 Quantity: {receiptData.txtqtyc2}";
                    txtC2Qty.Visibility = ViewStates.Visible;
                }

                if (receiptData.txtqtycoke > 0)
                {
                    txtCokeQty.Text = $"Coke Quantity: {receiptData.txtqtycoke}";
                    txtCokeQty.Visibility = ViewStates.Visible;
                }

                if (receiptData.txtqtyubecake > 0)
                {
                    txtUbeCakeQty.Text = $"Ube Cake Quantity: {receiptData.txtqtyubecake}";
                    txtUbeCakeQty.Visibility = ViewStates.Visible;
                }

                if (receiptData.txtqtycarrotcake > 0)
                {
                    txtCarrotCakeQty.Text = $"Carrot Cake Quantity: {receiptData.txtqtycarrotcake}";
                    txtCarrotCakeQty.Visibility = ViewStates.Visible;
                }

                if (receiptData.txtqtychococake > 0)
                {
                    txtChocoCakeQty.Text = $"Chocolate Cake Quantity: {receiptData.txtqtychococake}";
                    txtChocoCakeQty.Visibility = ViewStates.Visible;
                }

                if (receiptData.txtqtycheesecake > 0)
                {
                    txtCheeseCakeQty.Text = $"Cheese Cake Quantity: {receiptData.txtqtycheesecake}";
                    txtCheeseCakeQty.Visibility = ViewStates.Visible;
                }

                if (receiptData.txtqtyoreocake > 0)
                {
                    txtOreoCakeQty.Text = $"Oreo Cake Quantity: {receiptData.txtqtyoreocake}";
                    txtOreoCakeQty.Visibility = ViewStates.Visible;
                }

                // Always display the total price
                txtTotalPrice.Text = $"Total Price: {receiptData.totalp}";
                txtTotalPrice.Visibility = ViewStates.Visible;
            }
            button1 = FindViewById<Button>(Resource.Id.button1);
            button2 = FindViewById<Button>(Resource.Id.button2);

            button1.Click += Button1_Click;
        }
    
        private void Button1_Click(object sender, EventArgs e)
        {
            {
                
                    Intent intent = new Intent(this, typeof(BreadActivity));

                    yeabro yeabro = new yeabro()
                    {
                        txtqtymeat = meatcount,
                        txtqtyube = ubecount,
                        txtqtykwason = kwasoncount,
                        txtqtybaguette = baguettecount,
                        txtqtycheese = cheesecount,
                        txtqtyspanish = spanishcount,
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