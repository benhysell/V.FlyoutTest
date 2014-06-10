// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the LoginViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.FieldBinding;
using Cirrious.MvvmCross.Plugins.Messenger;
using V.FlyoutTest.Core.Entities;

namespace V.FlyoutTest.Core.ViewModels
{
    /// <summary>
    /// Define the LoginViewModel type.
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        readonly IMvxMessenger messenger = Mvx.Resolve<IMvxMessenger>();

        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                SetProperty(ref username, value, () => Username);
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                SetProperty(ref password, value, () => Password);
            }
        }


        /// <summary>
        /// Attempt to log into the system
        /// </summary>
        public void LoginCommand()
        {
            messenger.Publish(new LoginCompleteMessage(this));
            Close(this);
        }
    }
}
