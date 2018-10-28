using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace spinner
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Spinner);

            Spinner spinnerDays = FindViewById<Spinner>(Resource.Id.spinner1);
            spinnerDays.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(SelectedDay); // ojo envia un delagado con igual parametros requeiridos ???? -hjoab
            //spinnerDays.ItemSelected += SelectedDay;  // este tambien sirve --hjoab

            var adapter = ArrayAdapter.CreateFromResource(this,
               Resource.Array.days_array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinnerDays.Adapter = adapter;
        }
        private void SelectedDay(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            string toast = string.Format("The selected day is {0} ", spinner.GetItemAtPosition(e.Position)); 
           Toast.MakeText(this, toast, ToastLength.Long).Show();
        }
    }
}