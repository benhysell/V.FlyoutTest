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
        public EnterTimeView()
        {            
            this.NavigationItem.LeftBarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.Pause,
                                                                         (delegate
                                                                         {
                                                                             var messenger = Mvx.Resolve<IMvxMessenger>();
                                                                             messenger.Publish(new Message(this));                                                                             
                                                                         }));
            this.NavigationItem.RightBarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.Save, (delegate
            {                
                var viewmodel = ViewModel as EnterTimeViewModel;
                viewmodel.ShowFirstView();                
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
            this.View = new UIView { BackgroundColor = UIColor.Blue };

            base.ViewDidLoad();
            Title = "Enter Time";
        }

        
    }
}
