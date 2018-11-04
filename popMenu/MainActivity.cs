using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace popMenu
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            Button showPopupMenu = FindViewById<Button>(Resource.Id.popupButton);
            showPopupMenu.Click += (s, arg) => {
                PopupMenu menu = new PopupMenu(this, showPopupMenu);
                menu.Inflate(Resource.Menu.popMenu);
                menu.Show();
            };
        }
    }
}