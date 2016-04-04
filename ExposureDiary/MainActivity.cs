using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ExposureDiary
{
    [Activity(Label = "ExposureDiary", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var manageCameras = FindViewById<Button>(Resource.Id.ManageCamerasBtn);
            manageCameras.Click += delegate 
            {
                StartActivity(typeof(ManageCamerasActivity));
            };

            var manageFilms = FindViewById<Button>(Resource.Id.ManageFilmsBtn);
            manageFilms.Click += delegate
            {
                StartActivity(typeof(ManageFilmsActivity));
            };

        }
    }

    [Activity(Label = "ManageCameras")]
    public class ManageCamerasActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ManageCameras);            
        }
    }

    [Activity(Label = "AddCamera")]
    public class AddCameraActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }

    [Activity(Label = "ManageFilms")]
    public class ManageFilmsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ManageFilms);
        }
    }
}

