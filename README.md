Android Development mit C# Xamarin Tutorial #2: Button Click EventHandler
=========================================================================

[![IMAGE ALT TEXT HERE](https://img.youtube.com/vi/4olqbw-a0Js/0.jpg)](https://www.youtube.com/watch?v=4olqbw-a0Js)

Schritt 1: Projekt öffnen
============================
Als erstes öffnen wir unser erstelltes Projekt aus den letzten Tutorial Video.
Du kannst es auch hier im Ordner FirstApp finden https://github.com/LysergixSound/CSharp-XamarinAndroid-2
Unser Projekt besteht zurzeit aus einer Activity die zwischen 2 Fragmenten navigiert.
Beide Fragmente besitzen jeweils einen Button. Einmal Resource.Id.buttonHome und Resource.Id.buttonSettings.

Schritt 2: Dem Button Click EventHandler eine Methode zuweisen
==============================================================
Wir öffnen unsere Dateien.
1. FragmentHome.cs
2. FragmentSettings.cs

Wenn wir jetzt dem Button Click EventHandler eine Methode zuweisen möchten, müssen wir das jeweilige Button Control erstmal finden.
Das machen wir mittels

```cs
view.FindViewById<Button>(Resource.Id.buttonHome)
```

für diesen Aufruf benötigen wir aber erstmal das View Objekt welches wir in der public override View OnCreateView() erstellen.

```cs
public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
{
    // Hier erstelllen wir unser View Objekt
    View view = inflater.Inflate(Resource.Layout.fragment_home, container, false);

    return view;    
}
```

So nun können wir unser Button Control holen und den EventHandler eine Methode zuweisen.

```cs
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
```

Wird der Button jetzt gedrückt wird die Methode OnClickButton(sender, e) aufgerufen. Diese existiert allerdings noch nicht deswegen erstellen wir sie jetzt

```cs
void OnClickButton(object sender, EventArgs e)
{
    // Einfachen Toast erstellen
    // Toast.MakeText benötigt den Context einer Activity. Da wir uns aber in einer Fragment Datei befinden geben wir Activity als parameter an.
    Toast.MakeText(Activity, "Übersicht", ToastLength.Long).Show();
}
```


Unsere Dateien sehen nun so aus:

1. FragmentHome.cs
  ```cs
  using System;
  using Android.OS;
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
  ```

2. FragmentHome.cs
  ```cs
  using System;
  using Android.OS;
  using Android.Views;
  using Android.Widget;

  namespace FirstApp
  {
      public class FragmentSettings : Android.Support.V4.App.Fragment
      {
          public override void OnCreate(Bundle savedInstanceState)
          {
              base.OnCreate(savedInstanceState);

              // Create your fragment here
          }

          public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
          {
              // Hier erstelllen wir unser View Objekt
              View view = inflater.Inflate(Resource.Layout.fragment_settings, container, false);

              // Hole Button Control
              Button btnSettings = view.FindViewById<Button>(Resource.Id.buttonSettings);
              // Weise dem Click EventHandler die Methode OnClickButton(sender, e) zu
              btnSettings.Click += OnClickButton;

              return view;

          }

          void OnClickButton(object sender, EventArgs e)
          {
            // Einfachen Toast erstellen
            // Toast.MakeText benötigt den Context einer Activity. Da wir uns aber in einer Fragment Datei befinden geben wir Activity als parameter an.
              Toast.MakeText(Activity, "Einstellungen", ToastLength.Long).Show();
          }
      }
  }
  ```
