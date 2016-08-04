using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iOSXamarinBenchmark
{
	partial class CameraAccessViewController : UIViewController
	{
		private UIImagePickerController picker { get; set; }

		public CameraAccessViewController (IntPtr handle) : base (handle)
		{
			
		}

		public override void ViewDidLoad ()
		{
			buttonTakePhoto.TouchUpInside += OpenCameraViewController;
		}

		public void OpenCameraViewController (object sender, EventArgs ea) {

			picker = new UIImagePickerController();
			picker.AllowsEditing = true;

			if(UIImagePickerController.IsSourceTypeAvailable(UIImagePickerControllerSourceType.Camera))
			{
				picker.SourceType = UIImagePickerControllerSourceType.Camera;
			}
			else if(UIImagePickerController.IsSourceTypeAvailable(UIImagePickerControllerSourceType.PhotoLibrary))
			{
				picker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
			}

			picker.FinishedPickingMedia += (s, e) => {
				UIImage editedImage = e.Info[UIImagePickerController.EditedImage] as UIImage;
				imageViewPhoto.Image = editedImage;
	
				picker.DismissViewController (true, null);
			};

			picker.Canceled  += (s, e) => {
				picker.DismissViewController(true, null);
			};

			PresentViewController(picker, true, null);
		}
	}
}