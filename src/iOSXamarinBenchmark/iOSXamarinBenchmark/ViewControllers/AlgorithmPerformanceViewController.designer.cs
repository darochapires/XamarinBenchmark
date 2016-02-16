// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iOSXamarinBenchmark
{
	[Register ("AlgorithmPerformanceViewController")]
	partial class AlgorithmPerformanceViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonRun { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonRunTen { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelFibonacciTime { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelFibonacciValue { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField textFieldNumberOfIterations { get; set; }

		[Action ("buttonRunTen_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void buttonRunTen_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (buttonRun != null) {
				buttonRun.Dispose ();
				buttonRun = null;
			}
			if (buttonRunTen != null) {
				buttonRunTen.Dispose ();
				buttonRunTen = null;
			}
			if (labelFibonacciTime != null) {
				labelFibonacciTime.Dispose ();
				labelFibonacciTime = null;
			}
			if (labelFibonacciValue != null) {
				labelFibonacciValue.Dispose ();
				labelFibonacciValue = null;
			}
			if (textFieldNumberOfIterations != null) {
				textFieldNumberOfIterations.Dispose ();
				textFieldNumberOfIterations = null;
			}
		}
	}
}
