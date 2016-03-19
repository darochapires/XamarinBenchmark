using Android.App;
using Android.OS;
using Android.Util;
using Android.Widget;
using System;
using System.Diagnostics;

namespace AndroidXamarinBenchmark.Activities
{

    [Activity(Label = "ActivityAlgorithmPerformance")]
    public class ActivityAlgorithmPerformance : Activity
    {
		private TextView textViewlTime1;
		private TextView textViewlTime2;
		private TextView textViewlTime3;
		private TextView textViewlTime4;
		private TextView textViewlTime5;
		private TextView textViewlTime6;
		private TextView textViewlTime7;
		private TextView textViewlTime8;
		private TextView textViewlTime9;
		private TextView textViewlTime10;
		private TextView textViewlTimeAverage;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ActivityAlgorithmPerformance);

			Button buttonRun = FindViewById<Button>(Resource.Id.buttonRun);
			Button buttonRunTenTimes = FindViewById<Button>(Resource.Id.buttonRunTenTimes);

			EditText editTextNumberOfIterations = FindViewById<EditText>(Resource.Id.editTextNumberOfIterations);

			textViewlTime1 = FindViewById<TextView>(Resource.Id.textViewlTime1);
			textViewlTime2 = FindViewById<TextView>(Resource.Id.textViewlTime2);
			textViewlTime3 = FindViewById<TextView>(Resource.Id.textViewlTime3);
			textViewlTime4 = FindViewById<TextView>(Resource.Id.textViewlTime4);
			textViewlTime5 = FindViewById<TextView>(Resource.Id.textViewlTime5);
			textViewlTime6 = FindViewById<TextView>(Resource.Id.textViewlTime6);
			textViewlTime7 = FindViewById<TextView>(Resource.Id.textViewlTime7);
			textViewlTime8 = FindViewById<TextView>(Resource.Id.textViewlTime8);
			textViewlTime9 = FindViewById<TextView>(Resource.Id.textViewlTime9);
			textViewlTime10 = FindViewById<TextView>(Resource.Id.textViewlTime10);
			textViewlTimeAverage = FindViewById<TextView>(Resource.Id.textViewlTimeAverage);

			buttonRun.Click += (sender, e) =>
			{
				RunOnUiThread(() =>
					{
						Stopwatch sw = new Stopwatch();
						int numberOfIterations = int.Parse(editTextNumberOfIterations.Text);

						//just to warm things up
						Fibonacci(10);

						sw.Start();
						int result = Fibonacci(numberOfIterations);
						sw.Stop();

						textViewlTime1.Text = "Time: " + sw.ElapsedMilliseconds;
						textViewlTime2.Text = "";
						textViewlTime3.Text = "";
						textViewlTime4.Text = "";
						textViewlTime5.Text = "";
						textViewlTime6.Text = "";
						textViewlTime7.Text = "";
						textViewlTime8.Text = "";
						textViewlTime9.Text = "";
						textViewlTime10.Text = "";
						textViewlTimeAverage.Text = "";
					});
			};

			buttonRunTenTimes.Click += (sender, e) =>
			{
				RunOnUiThread(() =>
					{
						Stopwatch sw = new Stopwatch();
						int numberOfIterations = int.Parse(editTextNumberOfIterations.Text);

						//just to warm things up
						Fibonacci(10);

						long totalTime = 0;
						for(int i = 1; i <= 10; i++) {
							sw.Start();
							int result = Fibonacci(numberOfIterations);
							sw.Stop();

							long elapsedMilli = sw.ElapsedMilliseconds;
							totalTime += elapsedMilli;
							string timeElapsedText = "Time " + i + ": " + elapsedMilli;
							switch(i) {
							case 1:
								textViewlTime1.Text = timeElapsedText;
								break;
							case 2:
								textViewlTime2.Text = timeElapsedText;
								break;
							case 3:
								textViewlTime3.Text = timeElapsedText;
								break;
							case 4:
								textViewlTime4.Text = timeElapsedText;
								break;
							case 5:
								textViewlTime5.Text = timeElapsedText;
								break;
							case 6:
								textViewlTime6.Text = timeElapsedText;
								break;
							case 7:
								textViewlTime7.Text = timeElapsedText;
								break;
							case 8:
								textViewlTime8.Text = timeElapsedText;
								break;
							case 9:
								textViewlTime9.Text = timeElapsedText;
								break;
							case 10:
								textViewlTime10.Text = timeElapsedText;
								break;
							default:
								break;
                            }
                            Log.Info("AlgorithmPerformance", timeElapsedText);

                            sw.Reset();
						}
						textViewlTimeAverage.Text = "Average Time: " + totalTime / 10;
                        Log.Info("AlgorithmPerformance", textViewlTimeAverage.Text);
                    });
			};
        }

        public static int Fibonacci(int number)
        {
            if (number == 0) {
                return 0;
            } else if (number == 1) {
                return 1;
            } else
            {
                return Fibonacci(number - 2) + Fibonacci(number - 1);
            }
        }

    }

}