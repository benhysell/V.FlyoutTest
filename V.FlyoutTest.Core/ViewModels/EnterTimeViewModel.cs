// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the EnterTimeViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Windows.Input;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Plugins.Messenger;
using Cirrious.MvvmCross.ViewModels;
using V.FlyoutTest.Core.Entities;

namespace V.FlyoutTest.Core.ViewModels
{
    /// <summary>
    /// Define the EnterTimeViewModel type.
    /// </summary>
    public class EnterTimeViewModel : BaseViewModel
    {
        private MvxSubscriptionToken loginToken;
        private MvxSubscriptionToken loadHoursToken;
        readonly IMvxMessenger messenger = Mvx.Resolve<IMvxMessenger>();

        /// <summary>
        /// Example of showing the next view
        /// </summary>
        public void ShowFirstView()
        {
            this.ShowViewModel<AddHoursEntryViewModel>();
        }

        public override void Start()
        {
            base.Start();
            //subscribe to login request            
            loginToken = messenger.SubscribeOnMainThread<LoginRequestMessage>(OnLoginRequestMessage);            
        }

        /// <summary>
        /// Attempt to log into system
        /// </summary>
        /// <param name="obj"></param>
        private void OnLoginRequestMessage(LoginRequestMessage obj)
        {           
            ShowViewModel<LoginViewModel>();
        }


        private MvxCommand reloadCommand;
        public ICommand ReloadCommand
        {
            get
            {
                return reloadCommand ?? (reloadCommand = new MvxCommand(RefreshHoursFromTable));
            }
        }

        /// <summary>
        /// Uses built in table refresh mechanism instead of whole screen hud
        /// </summary>
        private void RefreshHoursFromTable()
        {
            //simple no-op command
        }
    }
}
