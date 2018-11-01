using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace multiScreen
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]  //  false --hjoab because if not we got 2 apps installed 
    public class SuscessfulRegistration : AppCompatActivity
    {

        //public event EventHandler<OnSignUpEvent> onSignUpComplete;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.home);
            setUserData();
        }

        protected void setUserData ()
        {
            //var tvhome = FindViewById<TextView>(Resource.Id.textViewHome);
            //var tvwelcome = FindViewById<TextView>(Resource.Id.textViewWelcome);
            var userName = FindViewById<TextView>(Resource.Id.userName);
            userName.Text  = "Your name: " + Intent.GetStringExtra("userName") ?? string.Empty;
            var userEmail  = FindViewById<TextView>(Resource.Id.userEmail);
            userEmail.Text = "Your email: " + Intent.GetStringExtra("userEmail") ?? string.Empty;
        }
    }
}