using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using Java.Lang;
using System.Runtime.Remoting.Contexts;
using Android.Content;

namespace gallery
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.gallery);
     

            Gallery myGallery = (Gallery)FindViewById<Gallery>(Resource.Id.gallery);  //This widget was deprecated in Android 4.1 (API level 16).
            myGallery.Adapter = new ImageAdapter(this);
            myGallery.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(this,
                   args.Position.ToString(), ToastLength.Short).Show();
            };
        }

        public class ImageAdapter : BaseAdapter
        {
            private Android.Content.Context cont;

            private MainActivity mainActivity;

            private int[] imageArraylist = {
                Resource.Drawable.img1,
                Resource.Drawable.img2,
                Resource.Drawable.img3,
                Resource.Drawable.img4,
                Resource.Drawable.img5,
                Resource.Drawable.img6,
            };


            public ImageAdapter(Android.Content.Context ct)
            {
                cont = ct;
            }

            public ImageAdapter(MainActivity mainActivity)
            {
                this.mainActivity = mainActivity;
            }

            //public override int Count => throw new System.NotImplementedException();
            public override int Count
            {
                get
                {
                    return imageArraylist.Length;
                }
            }

            public override Java.Lang.Object GetItem(int position)
            {
                return null;
            }
            public override long GetItemId(int position)
            {
                return 0;
            }

            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                ImageView img = new ImageView(cont);
                img.SetImageResource(imageArraylist[position]);
                img.SetScaleType(ImageView.ScaleType.FitXy);
                img.LayoutParameters = new Gallery.LayoutParams(200, 100);
                return img;
            }


        }

  

    
    }
}