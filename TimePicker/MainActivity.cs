using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace timePicker
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private TextView showCurrentTime;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.TimePicker);

            TimePicker Tpicker = FindViewById<TimePicker>(Resource.Id.timePicker1);
            showCurrentTime = FindViewById<TextView>(Resource.Id.txt_showTime);
            setCurrentTime();
            Button button = FindViewById<Button>(Resource.Id.btnSetTime);

            button.Click += delegate {
                showCurrentTime.Text = String.Format("{0}:{1}",
                   Tpicker.CurrentHour, Tpicker.CurrentMinute);
            };
        }
        private void setCurrentTime()
        {
            string time = string.Format("{0}",
               System.DateTime.Now.ToString("HH:mm").PadLeft(2, '0'));
            showCurrentTime.Text = time;
        }
    }
}