// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the AddHoursEntryView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Cirrious.CrossCore;
using Cirrious.MvvmCross.Plugins.Messenger;
using V.FlyoutTest.Core.Entities;
using System.Linq;

namespace V.FlyoutTest.iOS.Views
{
    using Core.ViewModels;
    using Foundation;
    using UIKit;

    /// <summary>
    /// Defines the AddHoursEntryView type.
    /// </summary>
    [Register("AddHoursEntryView")]
    public class AddHoursEntryView : BaseView
    {

        public override void ViewWillDisappear(bool animated)
        {
            if (!NavigationController.ViewControllers.Contains(this))
            {
                // Back button was pressed.  We know this is true because self is no longer
                // in the navigation stack, hide MvvmCross's navigation menu
                var messenger = Mvx.Resolve<IMvxMessenger>();
                messenger.Publish(new NavigationBarHiddenMessage(this, true)); 
            }
            base.ViewWillDisappear(animated);
        }
        
        /// <summary>
        /// Views the did load.
        /// </summary>
        /// <summary>
        /// Called when the View is first loaded
        /// </summary>
        public override void ViewDidLoad()
        {
            this.View = new UIView { BackgroundColor = UIColor.White };

            base.ViewDidLoad();
            Title = "Add Hours Entry";
            UITapGestureRecognizer tap = new UITapGestureRecognizer(() => this.View.ResignFirstResponder());
            this.View.AddGestureRecognizer(tap);
        }
    }
}
