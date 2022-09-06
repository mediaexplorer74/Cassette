using System;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

//using MonoTouch.Foundation;
//using MonoTouch.UIKit;
using Foundation;
using UIKit;

using Xamarin.Juice;

namespace Cassette.iOS
{

	class BigCoverView : UIImageView
	{
		public event Action<BigCoverView> Tapped = delegate {};

		public BigCoverView ()
		{
			UserInteractionEnabled = true;
			AddGestureRecognizer (
				new UITapGestureRecognizer (() => Tapped (this))
			);
		}
	}
	
}
