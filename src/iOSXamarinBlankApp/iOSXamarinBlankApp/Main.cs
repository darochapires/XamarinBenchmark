using UIKit;
using System.Diagnostics;

namespace iOSXamarinBlankApp
{
	public class Application
	{
		public static Stopwatch LaunchStopwatch { get; set; }

		static void Main (string[] args)
		{
			LaunchStopwatch = new Stopwatch ();
			LaunchStopwatch.Start ();
			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}
