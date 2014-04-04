// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the HomeView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Dialog.Touch;
using Cirrious.MvvmCross.Plugins.Messenger;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.ViewModels;
using FlyoutNavigation;
using MonoTouch.Dialog;
using V.FlyoutTest.Core.Entities;

namespace V.FlyoutTest.iOS.Views
{
    using Core.ViewModels;
    using MonoTouch.Foundation;
    using MonoTouch.UIKit;

    /// <summary>
    /// Defines the HomeView type.
    /// </summary>
    [Register("HomeView")]
    public class HomeView : BaseView
    {
        FlyoutNavigationController navigation;
        private MvxSubscriptionToken navigationMenuToggleToken;
        private MvxSubscriptionToken navigationBarHiddenToken;

        /// <summary>
        /// Set bounds for FlyoutNavigation
        /// </summary>
        /// <param name="animated"></param>
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            navigation.View.Frame = UIScreen.MainScreen.Bounds;
            navigation.View.Bounds = UIScreen.MainScreen.Bounds;
        }

        /// <summary>
        /// Views the did load.
        /// </summary>
        /// <summary>
        /// Called when the View is first loaded
        /// </summary>
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationController.NavigationBarHidden = true;
            Title = "Home";
            this.View = new UIView { BackgroundColor = UIColor.White };

            navigation = new FlyoutNavigationController();

            View.AddSubview(navigation.View);
            this.AddChildViewController(navigation);

            //names of the views shown in the flyout
            var flyoutMenuElements = new Section();

            //views that will be shown when a menu item is selected
            var flyoutViewControllers = new List<UIViewController>();


            var homeViewModel = ViewModel as HomeViewModel;
            if (homeViewModel != null)
            {
                //create the ViewModels
                foreach (var viewModel in homeViewModel.MenuItems)
                {
                    var viewModelRequest = new MvxViewModelRequest
                    {
                        ViewModelType = viewModel.ViewModelType
                    };

                    flyoutViewControllers.Add(CreateMenuItemController(viewModelRequest));
                    flyoutMenuElements.Add(new StringElement(viewModel.Title));
                }
                navigation.ViewControllers = flyoutViewControllers.ToArray();

                //add the menu elements
                var rootElement = new RootElement("")
                {
                    flyoutMenuElements
                };
                navigation.NavigationRoot = rootElement;
            }

            //Listen to messages to toggle the menu and hide MvvmCrosses navigation bar
            var messenger = Mvx.Resolve<IMvxMessenger>();
            navigationMenuToggleToken = messenger.SubscribeOnMainThread<ToggleFlyoutMenuMessage>(message => navigation.ToggleMenu());
            navigationBarHiddenToken = messenger.SubscribeOnMainThread<NavigationBarHiddenMessage>(message => NavigationController.NavigationBarHidden = message.NavigationBarHidden);
        }

        /// <summary>
        /// Given a ViewModel create a UIViewController for the FlyoutNavigation control
        /// </summary>
        /// <param name="viewModelRequest"></param>
        /// <returns></returns>
        private UIViewController CreateMenuItemController(MvxViewModelRequest viewModelRequest)
        {
            var controller = new UINavigationController();
            var screen = this.CreateViewControllerFor(viewModelRequest) as UIViewController;
            controller.PushViewController(screen, false);
            return controller;
        }
    }
}
