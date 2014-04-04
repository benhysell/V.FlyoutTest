// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the EnterTimeView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Cirrious.CrossCore;
using Cirrious.MvvmCross.Plugins.Messenger;
using Cirrious.MvvmCross.Touch.Views;
using V.FlyoutTest.Core.Entities;

namespace V.FlyoutTest.iOS.Views
{
    using Core.ViewModels;
    using MonoTouch.Foundation;
    using MonoTouch.UIKit;

    /// <summary>
    /// Defines the EnterTimeView type.
    /// </summary>
    [Register("EnterTimeView")]
    public class EnterTimeView : BaseView
    {        
        /// <summary>
        /// Views the did load.
        /// </summary>
        /// <summary>
        /// Called when the View is first loaded
        /// </summary>
        public override void ViewDidLoad()
        {
            View = new UIView { BackgroundColor = UIColor.Blue };

            base.ViewDidLoad();
            Title = "Enter Time";
            NavigationItem.LeftBarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.Pause,
                                                                         (delegate
                                                                         {
                                                                             //message to show the menu
                                                                             var messenger = Mvx.Resolve<IMvxMessenger>();
                                                                             messenger.Publish(new ToggleFlyoutMenuMessage(this));
                                                                         }));
            NavigationItem.RightBarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.Add,
                                                                        (delegate
                                                                        {
                                                                            //hide MvvmCross navigation bar and show next view
                                                                            var messenger = Mvx.Resolve<IMvxMessenger>();
                                                                            messenger.Publish(new NavigationBarHiddenMessage(this, false));
                                                                            var viewmodel = ViewModel as EnterTimeViewModel;
                                                                            if (viewmodel != null) viewmodel.ShowFirstView();
                                                                        }));
        }
    }
}
