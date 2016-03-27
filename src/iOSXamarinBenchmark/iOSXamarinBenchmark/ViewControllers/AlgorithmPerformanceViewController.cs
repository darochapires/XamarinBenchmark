using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Diagnostics;

namespace iOSXamarinBenchmark
{
	partial class AlgorithmPerformanceViewController : UIViewController
	{
		public AlgorithmPerformanceViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			buttonRun.TouchUpInside += (sender, e) => {
				RunFibonacci ();
			};
		}

		partial void buttonRunTen_TouchUpInside (UIButton sender)
		{
//			for(int i = 0; i < 10; i++)
//			{
//				InvokeOnMainThread (() =>  {
//					int numberOfIterations = SetNumberOfIterations ();
//
//					Stopwatch watch = Stopwatch.StartNew ();
//					int result = Fibonacci (numberOfIterations);
//					watch.Stop ();
//
//					var elapsedMs = watch.ElapsedMilliseconds;
//
//				}
//			}
		}

		private void RunFibonacci ()
		{
			NSOperationQueue.MainQueue.AddOperation (
				() => {
					int numberOfIterations = SetNumberOfIterations ();
					textFieldNumberOfIterations.Text = numberOfIterations.ToString ();
					Stopwatch watch = Stopwatch.StartNew ();
					int result = Fibonacci (numberOfIterations);
					watch.Stop ();
					var elapsedMs = watch.ElapsedMilliseconds;
					labelFibonacciTime.Text = elapsedMs.ToString ();
					labelFibonacciValue.Text = result.ToString ();
					Console.WriteLine ("Fibonacci Value: " + result + " Duration in milis: " + elapsedMs);
				}
			);

//			InvokeOnMainThread (() =>  {
//			});
		}

		private int SetNumberOfIterations ()
		{
			return textFieldNumberOfIterations.Text.Equals ("") ? 40 : int.Parse (textFieldNumberOfIterations.Text);
		}

		private int Fibonacci(int num){
			if (num == 0) {
				return 0;
			}
			if (num == 1) {
				return 1;
			}
			return Fibonacci(num - 1) + Fibonacci(num - 2);
		}
	}
}
