﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace FirstApp
{
    public class FragmentHome : Android.Support.V4.App.Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.fragment_home, container, false);

            // Setze EventHandler
            Button btnHome = view.FindViewById<Button>(Resource.Id.buttonHome);
            btnHome.Click += OnClickButton;

            return view;
            
        }

        void OnClickButton(object sender, EventArgs e)
        {
            // TODO
            Toast.MakeText(Activity, "Übersicht", ToastLength.Long).Show();
        }
    }
}