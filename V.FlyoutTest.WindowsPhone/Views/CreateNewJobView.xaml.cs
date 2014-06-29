// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the FirstView.xaml type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Windows.Navigation;
using V.FlyoutTest.Core.ViewModels;

namespace V.FlyoutTest.WindowsPhone.Views
{
    /// <summary>
    ///    Defines the CreateNewJobView.xaml type.
    /// </summary>
    public partial class CreateNewJobView
    {
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FirstView"/> class.
        /// </summary>
        public CreateNewJobView()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Show the selection menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowMenu(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }
        
    }
}