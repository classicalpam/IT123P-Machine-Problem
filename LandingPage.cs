﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IT123P_Machine_Problem
{
    [Activity(Label = "LandingPage")]
    public class LandingPage : Activity
    {
        string login_name;
        TextView txt1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.landingpage);
            //testing for login basic form
            login_name = Intent.GetStringExtra("Name");
            txt1 = FindViewById<TextView>(Resource.Id.textView1);
            txt1.Text = login_name;
        }
    }
}