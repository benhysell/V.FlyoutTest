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
        /// <summary>
        /// Example of showing the next view
        /// </summary>
        public void ShowFirstView()
        {
            this.ShowViewModel<AddHoursEntryViewModel>();
        }        
        
    }
}
