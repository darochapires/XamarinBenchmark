using Android.App;
using Android.OS;
using Android.Widget;

namespace AndroidXamarinBenchmark.Activities
{

    [Activity(Label = "ActivityControlsVisualPerformance")]
    public class ActivityControlsVisualPerformance : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ActivityControlsVisualPerformance);

            LinearLayout linearLayoutWrapper = FindViewById<LinearLayout>(Resource.Id.linearLayout_wrapper);

            //TODO: test Out of memory
            for (int j = 0; j < 500; j++)
            {
                LinearLayout linearLayout = new LinearLayout(this);
                LinearLayout.LayoutParams linearLayoutParams = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MatchParent, LinearLayout.LayoutParams.WrapContent);
                linearLayout.Orientation = Orientation.Horizontal;
                linearLayoutWrapper.AddView(linearLayout, linearLayoutParams);

                for (int i = 0; i < 20; i++)
                {
                    Button button = new Button(this);
                    button.Text = "X";
                    linearLayoutParams = new LinearLayout.LayoutParams(0, LinearLayout.LayoutParams.WrapContent);
                    linearLayoutParams.Weight = 1;
                    linearLayout.AddView(button, linearLayoutParams);
                }

            }

        }
    }

}