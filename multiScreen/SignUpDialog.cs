using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace multiScreen
{

    public class OnSignUpEvent : EventArgs
    {
        private string myUserName;
        private string myEmail;
        private string myPassword;

        public string UserName
        {
            get
            {
                return myUserName;
            }
            set
            {
                myUserName = value;
            }
        }

        public string Email
        {
            get
            {
                return myEmail;
            }
            set
            {
                myEmail = value;
            }
        }

        public string Password
        {
            get
            {
                return myPassword;
            }
            set
            {
                myPassword = value;
            }
        }

        public OnSignUpEvent(string username, string
           email, string password) : base()
        {
            UserName = username;
            Email = email;
            Password = password;
        }
    }

    public class SignUpDialog : DialogFragment
    {
        private EditText txtUsername;
        private EditText txtEmail;
        private EditText txtPassword;
        private Button btnSaveSignUp;

        public event EventHandler<OnSignUpEvent> onSignUpComplete;

        public override View OnCreateView(LayoutInflater inflater,
           ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.registerDialog, container, false); //  false --hjoab

            txtUsername = view.FindViewById<EditText>(Resource.Id.txtUsername);
            txtEmail = view.FindViewById<EditText>(Resource.Id.txtEmail);
            txtPassword = view.FindViewById<EditText>(Resource.Id.txtPassword);
            btnSaveSignUp = view.FindViewById<Button>(Resource.Id.btnSave);
            btnSaveSignUp.Click += btnSaveSignUp_Click;
            return view;
        }

        void btnSaveSignUp_Click(object sender, EventArgs e)
        {
            onSignUpComplete.Invoke(this, new OnSignUpEvent(txtUsername.Text,
               txtEmail.Text, txtPassword.Text));
            this.Dismiss();
        }
    }
}