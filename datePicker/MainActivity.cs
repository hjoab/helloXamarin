
using System; 
using Android.App; 
using Android.Content; 
using Android.Runtime; 
using Android.Views; 
using Android.Widget; 
using Android.OS;
using Android.Support.V7.App;


//namespace HelloXamarin
namespace datePicker
{
    [Activity(MainLauncher = true)]  // esto me lo pidio cuando no compiló --hjoab
    public class MainActivity : Activity
    {
        
        private TextView showCurrentDate; // see Date Picker bello --hjoab

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.DatePicker);
            //SetContentView(Resource.Layout.activity_main);

            // DatePicker Sample

            DatePicker pickDate = FindViewById<DatePicker>(Resource.Id.datePicker1);
            showCurrentDate = FindViewById<TextView>(Resource.Id.txtShowDate);
            setCurrentDate();
            Button buttonDate = FindViewById<Button>(Resource.Id.btnSetDate);
            buttonDate.Click += delegate {
                showCurrentDate.Text = String.Format("{0}/{1}/{2}",
                   pickDate.Month, pickDate.DayOfMonth, pickDate.Year);
            };


        }

        private void setCurrentDate() // DatePicker Sample
        {
            string TodaysDate = string.Format("{0}",
               DateTime.Now.ToString("M/d/yyyy").PadLeft(2, '0'));
            showCurrentDate.Text = TodaysDate;
        }
        
    }
}