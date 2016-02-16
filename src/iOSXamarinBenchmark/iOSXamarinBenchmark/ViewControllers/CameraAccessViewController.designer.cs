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
	[Register ("CameraAccessViewController")]
	partial class CameraAccessViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonTakePhoto { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imageViewPhoto { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (buttonTakePhoto != null) {
				buttonTakePhoto.Dispose ();
				buttonTakePhoto = null;
			}
			if (imageViewPhoto != null) {
				imageViewPhoto.Dispose ();
				imageViewPhoto = null;
			}
		}
	}
}
