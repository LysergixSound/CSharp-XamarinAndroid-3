using System;
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
            // Hier erstelllen wir unser View Objekt
            View view = inflater.Inflate(Resource.Layout.fragment_home, container, false);

            // Hole Button Control
            Button btnHome = view.FindViewById<Button>(Resource.Id.buttonHome);
            // Weise dem Click EventHandler die Methode OnClickButton(sender, e) zu
            btnHome.Click += OnClickButton;

            return view;
            
        }

        void OnClickButton(object sender, EventArgs e)
        {
            // Einfachen Toast erstellen
            // Toast.MakeText benötigt den Context einer Activity. Da wir uns aber in einer Fragment Datei befinden geben wir Activity als parameter an.
            Toast.MakeText(Activity, "Übersicht", ToastLength.Long).Show();
        }
    }
}