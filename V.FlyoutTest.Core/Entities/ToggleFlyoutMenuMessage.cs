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
    public class ToggleFlyoutMenuMessage : MvxMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        /// <param name="sender">The sender.</param>
        public ToggleFlyoutMenuMessage(object sender)
            : base(sender)
        {
        }
    }
}
