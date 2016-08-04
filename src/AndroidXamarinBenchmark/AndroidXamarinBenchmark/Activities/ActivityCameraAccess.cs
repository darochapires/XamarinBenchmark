using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Provider;
using Android.Widget;

namespace AndroidXamarinBenchmark.Activities
{
    [Activity(Label = "ActivityCameraAccess")]
    public class ActivityCameraAccess : Activity
    {
        private static int CAPTURE_IMAGE_ACTIVITY_REQUEST_CODE = 100;
        private ImageView imageView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ActivityCameraAccess);

            imageView = FindViewById<ImageView>(Resource.Id.imageViewPhoto);
            Button photoButton = FindViewById<Button>(Resource.Id.buttonTakePhoto);

            photoButton.Click += (sender, e) =>
            {
                Intent intent = new Intent(MediaStore.ActionImageCapture);
                StartActivityForResult(intent, CAPTURE_IMAGE_ACTIVITY_REQUEST_CODE);
            };
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (requestCode == CAPTURE_IMAGE_ACTIVITY_REQUEST_CODE && resultCode == Result.Ok)
            {
                Bitmap photo = (Bitmap)data.Extras.Get("data");
                imageView.SetImageBitmap(photo);
            }
        }
    }
}