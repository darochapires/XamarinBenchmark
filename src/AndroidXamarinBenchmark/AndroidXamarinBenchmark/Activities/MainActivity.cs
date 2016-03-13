using Android.App;
using Android.Widget;
using Android.OS;
using AndroidXamarinBenchmark.Activities;

namespace AndroidXamarinBenchmark
{
    [Activity(Label = "AndroidXamarinBenchmark", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            Button buttonAlgorithmPerformance = FindViewById<Button>(Resource.Id.buttonAlgorithmPerformance);
            Button buttonListVisualPerformance = FindViewById<Button>(Resource.Id.buttonListVisualPerformance);
            Button buttonControlsVisualPerformance = FindViewById<Button>(Resource.Id.buttonControlsVisualPerformance);
            Button buttonMemoryTest = FindViewById<Button>(Resource.Id.buttonMemoryTest);
            Button buttonCameraAccess = FindViewById<Button>(Resource.Id.buttonCameraAccess);

            buttonAlgorithmPerformance.Click += (sender, e) =>
            {
                StartActivity(typeof(ActivityAlgorithmPerformance));
            };

            buttonListVisualPerformance.Click += (sender, e) =>
            {
                StartActivity(typeof(ActivityListVisualPerformance));
            };

            buttonControlsVisualPerformance.Click += (sender, e) =>
            {
                StartActivity(typeof(ActivityControlsVisualPerformance));
            };

            buttonCameraAccess.Click += (sender, e) =>
            {
                StartActivity(typeof(ActivityCameraAccess));
            };
        }

    }
}

