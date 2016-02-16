using System;

using UIKit;

namespace iOSXamarinBenchmark
{
	partial class ConstrolsVisualPerformanceViewController : UIViewController
	{
		public ConstrolsVisualPerformanceViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			for (int i = 0; i < 1000; i++) {
				UIButton button = UIButton.FromType(UIButtonType.Custom);
				button.Frame = new CoreGraphics.CGRect(260, 30, 50, 28);
				button.SetTitleColor (UIColor.Blue, UIControlState.Normal);
				button.SetTitle ("iOS Xamarin Benchmark", UIControlState.Normal);
				this.View.AddSubview (button);
				button.TranslatesAutoresizingMaskIntoConstraints = false;

				NSLayoutConstraint width = NSLayoutConstraint.Create (button, NSLayoutAttribute.Width, 0, this.View, NSLayoutAttribute.Width, 1.0f, 0);
				NSLayoutConstraint height = NSLayoutConstraint.Create (button, NSLayoutAttribute.Height, 0, this.View, NSLayoutAttribute.Height, 1.0f, 0);
				NSLayoutConstraint top = NSLayoutConstraint.Create (button, NSLayoutAttribute.Top, NSLayoutRelation.Equal, this.View, NSLayoutAttribute.Top, 1.0f, 0);
				NSLayoutConstraint leading = NSLayoutConstraint.Create (button, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, this.View, NSLayoutAttribute.Leading, 1.0f, 0);

				this.View.AddConstraint (width);
				this.View.AddConstraint (height);
				this.View.AddConstraint (top);
				this.View.AddConstraint (leading);
			}
		}

	}
}


