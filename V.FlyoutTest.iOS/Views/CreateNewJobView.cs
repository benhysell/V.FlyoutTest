// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the CreateNewJobView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Cirrious.CrossCore;
using Cirrious.MvvmCross.Plugins.Messenger;
using V.FlyoutTest.Core.Entities;

namespace V.FlyoutTest.iOS.Views
{
    using Core.ViewModels;
    using MonoTouch.Foundation;
    using MonoTouch.UIKit;

    /// <summary>
    /// Defines the CreateNewJobView type.
    /// </summary>
    [Register("CreateNewJobView")]
    public class CreateNewJobView : BaseView
    {

        public CreateNewJobView()
        {
            this.NavigationItem.LeftBarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.Pause,
                                                                         (delegate
                                                                         {
                                                                             var messenger = Mvx.Resolve<IMvxMessenger>();
                                                                             messenger.Publish(new Message(this));                                                                            
                                                                         }));
        }

        /// <summary>
        /// Views the did load.
        /// </summary>
        /// <summary>
        /// Called when the View is first loaded
        /// </summary>
        public override void ViewDidLoad()
        {
            this.View = new UIView { BackgroundColor = UIColor.Red };

            base.ViewDidLoad();
            Title = "Create New Job";

        }
    }
}
