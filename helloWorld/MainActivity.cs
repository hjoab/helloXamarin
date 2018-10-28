//using Android.App;
//using Android.OS;
//using Android.Support.V7.App;
//using Android.Runtime;
//using Android.Widget;

//namespace helloWorld
//{
//    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
//    public class MainActivity : AppCompatActivity
//    {
//        protected override void OnCreate(Bundle savedInstanceState)
//        {
//            base.OnCreate(savedInstanceState);
//            // Set our view from the "main" layout resource
//            SetContentView(Resource.Layout.activity_main);
//        }
//    }
//}


using System; 
using Android.App; 
using Android.Content; 
using Android.Runtime; 
using Android.Views; 
using Android.Widget; 
using Android.OS;
using Android.Support.V7.App;
using AlertDialog = Android.Support.V7.App.AlertDialog;

namespace helloWorld
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]  // esto me lo pidio cuando no compiló --hjoab
    public class MainActivity : Activity
    {
        
        private AutoCompleteTextView autoComplete1; // see AutoComplete bellow --hjoab

        private TextView showCurrentDate; // see Date Picker bello --hjoab

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            //SetContentView(Resource.Layout.activity_main);


            // RadioButton Sample

            RadioButton radio_Ferrari = FindViewById<RadioButton>
            (Resource.Id.radioFerrari);
            RadioButton radio_Mercedes = FindViewById<RadioButton>
            (Resource.Id.radioMercedes);
            RadioButton radio_Lambo = FindViewById<RadioButton>
            (Resource.Id.radioLamborghini);
            RadioButton radio_Audi = FindViewById<RadioButton>
            (Resource.Id.radioAudi);
            radio_Ferrari.Click += onClickRadioButton;
            radio_Mercedes.Click += onClickRadioButton;
            radio_Lambo.Click += onClickRadioButton;
            radio_Audi.Click += onClickRadioButton;

            // Button Sample

            Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += delegate { button.Text = "Hello world I am your first App"; };

            CheckBox checkMe = FindViewById<CheckBox>(Resource.Id.checkBox1);
            checkMe.CheckedChange += (object sender, CompoundButton.CheckedChangeEventArgs e) =>
            {
                CheckBox check = (CheckBox)sender;
                if (check.Checked)
                {
                    check.Text = "Checkbox has been checked";
                    Toast.MakeText(this, "Checkbox checked!", ToastLength.Short).Show();
                }
                else
                {
                    check.Text = "Checkbox has not been checked";
                    Toast.MakeText(this, "Checkbox unchecked!", ToastLength.Short).Show();
                }
            };

            // ProgressBar Sample

            ProgressBar pb = FindViewById<ProgressBar>(Resource.Id.progressBar1);
            pb.Progress = 35;

            ToggleButton togglebutton = FindViewById<ToggleButton>(Resource.Id.togglebutton);
            togglebutton.Click += (s, e) =>
            {
                if (togglebutton.Checked)
                    Toast.MakeText(this, "Torch is ON", ToastLength.Short).Show();
                else
                    Toast.MakeText(this, "Torch is OFF",
                    ToastLength.Short).Show();
            };

            // AutoComplete Sample

            autoComplete1 = FindViewById<AutoCompleteTextView>(Resource.Id.autoComplete1);
            Button btn_Submit = FindViewById<Button>(Resource.Id.btn_Submit);
            var names = new string[] { "John", "Peter", "Jane", "Britney" };
            ArrayAdapter adapter = new ArrayAdapter<string>(this,
               Android.Resource.Layout.SimpleSpinnerItem, names);
            autoComplete1.Adapter = adapter;
            btn_Submit.Click += ClickedBtnSubmit;


            // RatingBar Sample

            var ratingBar = FindViewById<RatingBar>(Resource.Id.ratingBar1);
            ratingBar.RatingBarChange += (o, e) =>
            {
                Toast.MakeText(this, "New Rating: " + ratingBar.Rating.ToString(), ToastLength.Short).Show();
            };

            // Alert Dialog Sample

            Button buttonAlert = FindViewById<Button>(Resource.Id.buttonAlert);
            buttonAlert.Click += delegate {
                AlertDialog.Builder alertDiag = new AlertDialog.Builder(this);
                alertDiag.SetTitle("Confirm delete");
                alertDiag.SetMessage("Once deleted the move cannot be undone");
                alertDiag.SetPositiveButton("Delete", (senderAlert, args) => {
                    Toast.MakeText(this, "Deleted", ToastLength.Short).Show();
                });
                alertDiag.SetNegativeButton("Cancel", (senderAlert, args) => {
                    alertDiag.Dispose();
                });
                Dialog diag = alertDiag.Create();
                diag.Show();
            };
        }
        
        private void onClickRadioButton(object sender, EventArgs e) // RadioButton Sample
        {
            RadioButton cars = (RadioButton)sender;
            Toast.MakeText(this,  "Your favorite car is: " + cars.Text, ToastLength.Short).Show // small message in a pop ---hjoab
            ();
        }

        protected void ClickedBtnSubmit(object sender, System.EventArgs e) // AutoComplete Sample
        {
            if (autoComplete1.Text != "")
            {
                Toast.MakeText(this, "The Name Entered ="
                   + autoComplete1.Text, ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(this, "Enter a Name!", ToastLength.Short).Show();
            }
        }
    }
}