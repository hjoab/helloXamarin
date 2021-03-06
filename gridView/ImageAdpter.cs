﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace gridView
{
    public class ImageAdapter : BaseAdapter
    {
        Context context;
        public ImageAdapter(Context ch)
        {
            context = ch;
        }

        public override int Count
        {
            get
            {
                return cars.Length;
            }
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override View GetView(int position,
           View convertView, ViewGroup parent)
        {
            ImageView imageView;
            if (convertView == null)
            {
                imageView = new ImageView(context);
                imageView.LayoutParameters = new GridView.LayoutParams(100, 100);
                imageView.SetScaleType(ImageView.ScaleType.FitCenter);
                imageView.SetPadding(8, 8, 8, 8);
                //imageView.SetPadding(0, 0, 0, 0);
            }
            else
            {
                imageView = (ImageView)convertView;
            }

            imageView.SetImageResource(cars[position]);
            return imageView;
        }

        int[] cars = {
            Resource.Drawable.img1, Resource.Drawable.img2,
            Resource.Drawable.img3, Resource.Drawable.img4,
            Resource.Drawable.img5, Resource.Drawable.img6,
            Resource.Drawable.img1, Resource.Drawable.img2,
            Resource.Drawable.img3, Resource.Drawable.img4,
            Resource.Drawable.img5, Resource.Drawable.img6,
            Resource.Drawable.img1, Resource.Drawable.img2,
            Resource.Drawable.img3, Resource.Drawable.img4,
            Resource.Drawable.img5, Resource.Drawable.img6,
            Resource.Drawable.img1, Resource.Drawable.img2,
            Resource.Drawable.img3, Resource.Drawable.img4,
            Resource.Drawable.img5, Resource.Drawable.img6,
        };
    }
}