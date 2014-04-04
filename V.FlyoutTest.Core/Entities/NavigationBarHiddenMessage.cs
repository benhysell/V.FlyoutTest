// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the Message type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace V.FlyoutTest.Core.Entities
{
    using Cirrious.MvvmCross.Plugins.Messenger;

    /// <summary>
    ///    Defines the Message type.
    /// </summary>
    public class NavigationBarHiddenMessage : MvxMessage
    {
        public bool NavigationBarHidden;
        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        /// <param name="sender">The sender.</param>
        public NavigationBarHiddenMessage(object sender, bool navigationBarHidden)
            : base(sender)
        {
            NavigationBarHidden = navigationBarHidden;
        }
    }
}
