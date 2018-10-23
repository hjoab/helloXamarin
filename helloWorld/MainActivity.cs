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
    [Activity(MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
        }
    }
}