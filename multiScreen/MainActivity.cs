
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace multiScreen
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        //protected override void OnCreate(Bundle savedInstanceState)
        //{
        //    base.OnCreate(savedInstanceState);
        //    // Set our view from the "main" layout resource
        //    SetContentView(Resource.Layout.Main);

        private Button signUp;
        private Button submitNewUser;
        private EditText txtUsername;
        private EditText txtEmail;
        private EditText txtPassword;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            signUp = FindViewById<Button>(Resource.Id.btnSignUp);
            submitNewUser = FindViewById<Button>(Resource.Id.btnSave);
            txtUsername = FindViewById<EditText>(Resource.Id.txtUsername);
            txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);

            signUp.Click += (object sender, EventArgs args) => {
                FragmentTransaction transFrag = FragmentManager.BeginTransaction();
                SignUpDialog diagSignUp = new SignUpDialog();
                diagSignUp.Show(transFrag, "Fragment Dialog");
                diagSignUp.onSignUpComplete += diagSignUp_onSignUpComplete;
            };
        }
        void diagSignUp_onSignUpComplete(object sender, OnSignUpEvent e)
        {
            StartActivity(typeof(Activity2));
        }

    } 
}