using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.MvvmCross.Plugins.Messenger;

namespace V.FlyoutTest.Core.Entities
{
    public class LoginRequestMessage : MvxMessage
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        /// <param name="sender">The sender.</param>
        public LoginRequestMessage(object sender)
            : base(sender)
        {

        }
    }
}
