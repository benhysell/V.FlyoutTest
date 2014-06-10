// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the LoginView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Android.Views;
using Android.Widget;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Plugins.Messenger;
using V.FlyoutTest.Core.Entities;
using V.FlyoutTest.Core.ViewModels;

namespace V.FlyoutTest.Droid.Views
{
    using Android.App;
    using Android.OS;

    /// <summary>
    /// Defines the LoginView type.
    /// </summary>
    [Activity(Label = "Welcome", WindowSoftInputMode = SoftInput.StateVisible, ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    public class LoginView : BaseView
    {
        private MvxSubscriptionToken loginFailedToken;

        /// <summary>
        /// Called when [create].
        /// </summary>
        /// <param name="bundle">The bundle.</param>
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.SetContentView(Resource.Layout.LoginView);

            var messenger = Mvx.Resolve<IMvxMessenger>();
            loginFailedToken = messenger.SubscribeOnMainThread<LoginFailedMessage>(OnLoginFailedMessage);

            var passwordText = FindViewById<EditText>(Resource.Id.password);


            //clear password on touch
            passwordText.FocusChange += (sender, args) =>
            {
                if (CurrentFocus == passwordText)
                {
                    passwordText.Text = string.Empty;
                }
            };

            //login on return press
            passwordText.KeyPress += (sender, e) =>
            {
                e.Handled = false;
                if (e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter)
                {
                    var logInViewModel = ViewModel as LoginViewModel;
                    if (logInViewModel != null) logInViewModel.LoginCommand();
                    e.Handled = true;
                }
            };
        }

        /// <summary>
        /// Show error message on login failure
        /// </summary>
        /// <param name="message"></param>
        private void OnLoginFailedMessage(LoginFailedMessage message)
        {
            var builder = new AlertDialog.Builder(this);
            var alertDialog = builder.Create();
            alertDialog.SetTitle("Login Failed");
            alertDialog.SetIcon(Resource.Drawable.Icon);
            alertDialog.SetMessage("Login to JobTrak failed.  Please check your username and password");
            alertDialog.SetButton("OK", (s, ev) => alertDialog.Dismiss());
            alertDialog.Show();
        }
    }
}