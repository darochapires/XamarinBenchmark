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

namespace AndroidXamarinBenchmark.Activities
{
    [Activity(Label = "ActivityMemoryTest")]
    public class ActivityMemoryTest : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            ListView buttonRun = FindViewById<ListView>(Resource.Id.listView);

            base.OnCreate(bundle);
        }
    }
}