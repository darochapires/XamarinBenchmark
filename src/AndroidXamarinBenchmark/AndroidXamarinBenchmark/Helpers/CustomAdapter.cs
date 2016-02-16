using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidXamarinBenchmark.Activities;

namespace AndroidXamarinBenchmark.Helpers
{
    class CustomAdapter : BaseAdapter
    {
        //List<Contact> _contactList;
        ActivityListVisualPerformance _activity;
        private static int NUMBER_OF_ROWS = 50;

        public CustomAdapter(ActivityListVisualPerformance activity)
        {
            _activity = activity;
        }

        public override int Count
        {
            get { return NUMBER_OF_ROWS; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? _activity.LayoutInflater.Inflate(
                Resource.Layout.ListItem, parent, false);
            var textView = view.FindViewById<TextView>(Resource.Id.textView);
            var imageView = view.FindViewById<ImageView>(Resource.Id.imageView);
            textView.Text = "elebleriii";

            //if (_contactList[position].PhotoId == null)
            //{
            //    imageView = view.FindViewById<ImageView>(Resource.Id.imageView);
            imageView.SetImageResource(Resource.Drawable.profilePic);
            //}
            //else
            //{
            //    var contactUri = ContentUris.WithAppendedId(
            //        ContactsContract.Contacts.ContentUri, _contactList[position].Id);
            //    var contactPhotoUri = Android.Net.Uri.WithAppendedPath(contactUri,
            //        Contacts.Photos.ContentDirectory);
            //    imageView.SetImageURI(contactPhotoUri);
            //}
            return view;
        }
    }
}