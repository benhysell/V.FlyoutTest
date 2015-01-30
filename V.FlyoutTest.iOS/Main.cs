// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the Main type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace V.FlyoutTest.iOS
{
    using UIKit;

    /// <summary>
    ///    Defines the Main type.
    /// </summary>
    public class Application
    {
        /// <summary>
        /// This is the main entry point of the application.
        /// </summary>
        /// <param name="args">The args.</param>
        public static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}