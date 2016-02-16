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

		public void OpenCameraViewController (object sender, EventArgs ea) {

			picker = new UIImagePickerController();
			picker.AllowsEditing = true;

			if(UIImagePickerController.IsSourceTypeAvailable(UIImagePickerControllerSourceType.Camera))//[UIImagePickerController isSourceTypeAvailable:UIImagePickerControllerSourceTypeCamera])
			{
				picker.SourceType = UIImagePickerControllerSourceType.Camera;
			}
			else if(UIImagePickerController.IsSourceTypeAvailable(UIImagePickerControllerSourceType.PhotoLibrary))//[UIImagePickerController isSourceTypeAvailable:UIImagePickerControllerSourceTypeCamera])
			{
				picker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
			}


			picker.FinishedPickingMedia += (s, e) => {
//			picker.FinishedPickingImage += (s, e) => {
//				UIImage editedImage = e.EditingInfo[UIImagePickerController.EditedImage] as UIImage;
				UIImage editedImage = e.Info[UIImagePickerController.EditedImage] as UIImage;//.EditingInfo[UIImagePickerController.EditedImage] as UIImage;
				imageViewPhoto.Image = editedImage;
	
				picker.DismissViewController (true, null);
			};

			picker.Canceled  += (s, e) => {
				picker.DismissViewController(true, null);
			};

			PresentViewController(picker, true, null);
		}

//		protected void HandleFinishedPickingMedia(object sender, UIImagePickerImagePickedEventArgs e)
//		{
//			UIImage editedImage = e.EditingInfo[UIImagePickerController.EditedImage] as UIImage;
//			imageViewPhoto.Image = editedImage;
//
//			picker.DismissViewController (true, null);
//		}
//
//		protected void HandleCanceledPickingMedia(object sender, UIImagePickerMediaPickedEventArgs e)
//		{
//			picker.DismissViewController(true, null);
//		}

		public override void ViewDidLoad ()
		{
			buttonTakePhoto.TouchUpInside += OpenCameraViewController;
		}
	}
}
