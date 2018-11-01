
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
            //StartActivity(typeof(SuscessfulRegistration));

            //txtUsername.Text = e.UserName;
            //txtEmail.Text = e.Email;
            //txtPassword.Text = e.Password;

            var activity2 = new Android.Content.Intent(this, typeof(SuscessfulRegistration));
            activity2.PutExtra("userData", "Your Name: " + e.UserName + " Your eMail: " + e.Email);
            activity2.PutExtra("userName", e.UserName);
            activity2.PutExtra("userEmail", e.Email);

            StartActivity(activity2);
        }

    } 
}