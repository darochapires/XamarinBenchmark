// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace iOSXamarinBenchmark
{
	public partial class VisualPerformanceTableViewController : UITableViewController
	{
		private CellInfo[] Cells;

		public VisualPerformanceTableViewController (IntPtr handle) : base (handle)
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			Cells = new CellInfo[1000];

			for (int i = 0; i < 1000; i++) {
//				UIImage img = UIImage.FromBundle("pic");
				CellInfo cell = new CellInfo("iOS Xamarin Benchmark cell " + i, "xamarin.png");
				Cells[i] = cell;
			}
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection (UITableView tableView, nint section)
		{
			return Cells.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = TableView.DequeueReusableCell ("simpleCell");
			CellInfo info = Cells [indexPath.Row];

			cell.TextLabel.Text = info.TextInfo;
			UIImage img = UIImage.FromFile (info.ImageName);

			cell.ImageView.Image = img;//info.Image;

			return cell;
		}
	}
}
