using System;

using UIKit;

namespace iOSXamarinBlankApp
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidAppear (bool animated)
		{
			var elapsedTimeSinceLaunch = Application.LaunchStopwatch.ElapsedMilliseconds;
			UIAlertView alert = new UIAlertView ("Launch Time", elapsedTimeSinceLaunch + " miliseconds", null, "OK", null);
			alert.Show ();

			base.ViewDidAppear (animated);
		}
	}
}

