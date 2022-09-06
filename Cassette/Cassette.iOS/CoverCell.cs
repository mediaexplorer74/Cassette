using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;

//using MonoTouch.Foundation;
//using MonoTouch.UIKit;
using Foundation;
using UIKit;

using Xamarin.Juice;

namespace Cassette.iOS
{
	class CoverCell : UICollectionViewCell
	{
		UIImageView ImageView;

		public static readonly SizeF DefaultSize;

		static CoverCell ()
		{
			var size = UIScreen.MainScreen.Bounds.Width / 2;
			DefaultSize = new SizeF ((float)size, (float)size);
		}

		public CoverCell (IntPtr handle) : base (handle)
		{
			Frame = new RectangleF (PointF.Empty, DefaultSize);
			ImageView = new UIImageView (Frame);
			ContentView.Add (ImageView);
		}

		public UIImage CoverImage {
			get { return ImageView.Image; }
			set {
				ImageView.Image = value;
			}
		}
	}
	
}
