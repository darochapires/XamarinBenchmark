using System;
using UIKit;

namespace iOSXamarinBenchmark
{
	public class CellInfo
	{

		public string TextInfo { get; }
//		public UIImage Image { get; }
		public string ImageName { get; }

		public CellInfo (string textInfo, string imageName)
		{
			TextInfo = textInfo;
			ImageName = imageName;
		}
	}
}

