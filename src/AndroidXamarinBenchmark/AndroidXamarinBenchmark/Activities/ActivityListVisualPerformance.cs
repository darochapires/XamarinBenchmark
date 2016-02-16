using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidXamarinBenchmark.Helpers;

namespace AndroidXamarinBenchmark.Activities
{
    [Activity(Label = "ActivityListVisualPerformance")]
    public class ActivityListVisualPerformance : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ActivityListVisualPerformance);

            ListView listView = FindViewById<ListView>(Resource.Id.listView);
            listView.Adapter = new CustomAdapter(this);
        }
    }
}