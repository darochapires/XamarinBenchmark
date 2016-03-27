using Android.App;
using Android.OS;
using Android.Util;
using Android.Widget;
using System.Diagnostics;

namespace AndroidXamarinBenchmark.Activities
{

    [Activity(Label = "ActivityControlsVisualPerformance")]
    public class ActivityControlsVisualPerformance : Activity
    {

        private long _timeElapsed { get; set; }

        private long _startTime { get; set; }


        private Stopwatch Stopwatch;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ActivityControlsVisualPerformance);

            LinearLayout linearLayoutWrapper = FindViewById<LinearLayout>(Resource.Id.linearLayout_wrapper);

            Stopwatch = new Stopwatch();
            Stopwatch.Start();

            //TODO: test Out of memory
            for (int j = 0; j < 450; j++)
            {
                LinearLayout linearLayout = new LinearLayout(this);
                LinearLayout.LayoutParams linearLayoutParams = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WrapContent, LinearLayout.LayoutParams.WrapContent);
                linearLayout.Orientation = Orientation.Horizontal;
                linearLayoutWrapper.AddView(linearLayout, linearLayoutParams);

                for (int i = 0; i < 20; i++)
                {
                    Button button = new Button(this);
                    button.Text = "X";
                    button.Click += Button_Click;
                    linearLayoutParams = new LinearLayout.LayoutParams(0, LinearLayout.LayoutParams.WrapContent);
                    linearLayoutParams.Weight = 1;
                    linearLayout.AddView(button, linearLayoutParams);
                }
            }
        }

        public override void OnWindowFocusChanged(bool hasFocus)
        {
            base.OnWindowFocusChanged(hasFocus);
            if (_timeElapsed == 0)
            {
                Log.Info("benchmark", "ActivityControlsVisualPerformance Finished");
                Stopwatch.Stop();
                _timeElapsed = Stopwatch.ElapsedMilliseconds;
            }
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            new AlertDialog.Builder(this)
                    .SetTitle("Time elapsed")
                    .SetMessage(_timeElapsed + " miliseconds")
                    .SetNeutralButton("", (s, e2) => { })
                    .Show();
        }
    }

}