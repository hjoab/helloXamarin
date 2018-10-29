using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace listView
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource

            SetContentView(Resource.Layout.Main);
            var listView = FindViewById<ListView>(Resource.Id.listView1);
            var data = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            listView.Adapter = new ArrayAdapter(this, Resource.Layout.listViewTemplate, data);
            listView.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(SelectedListItem); // ojo envia un delagado con igual parametros requeiridos ???? --hjoab
            //listView.ItemSelected += SelectedListItem;
        }

        private void SelectedListItem(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var listView = (ListView)sender;
            string toast = string.Format("The selected day is {0} ", listView.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }
    }
}