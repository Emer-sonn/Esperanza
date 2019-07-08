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


namespace Esperanza.Droid
{
    [Activity(Theme ="@style/emerson.Theme",
        Icon = "@drawable/logo2",
        NoHistory =true,
        MainLauncher =true
        )]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            System.Threading.Thread.Sleep(2000);
            StartActivity(typeof(MainActivity));

            // Create your application here
        }
    }
}