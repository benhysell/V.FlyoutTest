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
        private MvxSubscriptionToken navigationToken;

       
        string[] Tasks = {
			"Enter Time",
			"Create New Job"			
		};
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
            navigation.View.Frame = UIScreen.MainScreen.Bounds;
            
            ////add both view controllers
            View.AddSubview(navigation.View);
            this.AddChildViewController(navigation);

            var section = new Section();
            section.AddAll(from page in Tasks
                           select new StringElement(page) as Element);
            var rootElement = new RootElement("");
            rootElement.Add(section);
            navigation.NavigationRoot = rootElement;

            var viewControllers = new List<UIViewController>();
            var homeViewModel = ViewModel as HomeViewModel;
            foreach (var viewModel2 in homeViewModel.MenuItems)
            {
                MvxViewModelRequest x = new MvxViewModelRequest
                {
                    ViewModelType = viewModel2.ViewModelType
                };

                viewControllers.Add(CreateMenuItemController(x));
            }                       
            navigation.ViewControllers = viewControllers.ToArray();
            
            
            var messenger = Mvx.Resolve<IMvxMessenger>();
            navigationToken = messenger.SubscribeOnMainThread<Message>(OnNavigationMessage);            
        }
        
       /// <summary>
       /// Toggle the menu open/close
       /// </summary>
       /// <param name="obj"></param>
        private void OnNavigationMessage(Message obj)
        {
            navigation.ToggleMenu();
        }


        private UIViewController CreateMenuItemController(MvxViewModelRequest x)        
        {
            var controller = new UINavigationController();

            var screen = this.CreateViewControllerFor(x) as UIViewController;
            controller.PushViewController(screen, false);
            return controller;
        }

        private UINavigationController CreateMenuItemController<TViewModel>() where TViewModel : BaseViewModel
        {
            var controller = new UINavigationController();            
            var screen = this.CreateViewControllerFor<TViewModel>() as UIViewController;
            controller.PushViewController(screen, false);
            return controller;
        }
    }
}
