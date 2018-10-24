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


//namespace HelloXamarin
namespace helloWorld
{
    [Activity(MainLauncher = true)]  // esto me lo pidio cuando no compiló --hjoab
    public class MainActivity : Activity
    {

        AutoCompleteTextView autoComplete1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

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

            Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += delegate { button.Text = "Hello world I am your first App"; };

            CheckBox checkMe = FindViewById<CheckBox>(Resource.Id.checkBox1);
            checkMe.CheckedChange += (object sender, CompoundButton.CheckedChangeEventArgs e) => {
                CheckBox check = (CheckBox)sender;
                if (check.Checked)
                {
                    check.Text = "Checkbox has been checked";
                }
                else
                {
                    check.Text = "Checkbox has not been checked";
                }
            };

            ProgressBar pb = FindViewById<ProgressBar>(Resource.Id.progressBar1);
            pb.Progress = 35;

            ToggleButton togglebutton = FindViewById<ToggleButton>(Resource.Id.togglebutton);
            togglebutton.Click += (s, e) => {
                if (togglebutton.Checked)
                    Toast.MakeText(this, "Torch is ON", ToastLength.Short).Show();                    
                else
                    Toast.MakeText(this, "Torch is OFF",
                    ToastLength.Short).Show();
            };


            autoComplete1 = FindViewById<AutoCompleteTextView>(Resource.Id.autoComplete1);
            Button btn_Submit = FindViewById<Button>(Resource.Id.btn_Submit);
            var names = new string[] { "John", "Peter", "Jane", "Britney" };
            ArrayAdapter adapter = new ArrayAdapter<string>(this,
               Android.Resource.Layout.SimpleSpinnerItem, names);
            autoComplete1.Adapter = adapter;
            btn_Submit.Click += ClickedBtnSubmit;

        }

        private void onClickRadioButton(object sender, EventArgs e)
        {
            RadioButton cars = (RadioButton)sender;
            Toast.MakeText(this, cars.Text, ToastLength.Short).Show // small message in a pop ---hjoab
            ();
        }

        protected void ClickedBtnSubmit(object sender, System.EventArgs e)
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