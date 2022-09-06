using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Cassette.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        // window
        UIWindow window;

        // FinishedLaunching
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            window = new UIWindow(UIScreen.MainScreen.Bounds)
            {
                RootViewController = new TopLevelController
                {
                    ContentController = new ContentController((System.Drawing.RectangleF)UIScreen.MainScreen.Bounds)
                }
            };
            window.MakeKeyAndVisible();

            return true;

        }//FinishedLaunching end

        /*
       public override bool FinishedLaunching(UIApplication app, NSDictionary options)
       {
           global::Xamarin.Forms.Forms.Init();
           LoadApplication(new App());

           return base.FinishedLaunching(app, options);
       }
       */
    }
}


