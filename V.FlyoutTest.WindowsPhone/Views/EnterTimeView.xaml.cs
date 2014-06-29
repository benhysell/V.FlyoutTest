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
    ///    Defines the EnterTimeView.xaml type.
    /// </summary>
    public partial class EnterTimeView
    {
        private EnterTimeViewModel viewModel;
        public new EnterTimeViewModel ViewModel
        {
            get { return viewModel ?? (viewModel = base.ViewModel as EnterTimeViewModel); }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="FirstView"/> class.
        /// </summary>
        public EnterTimeView()
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

        /// <summary>
        /// Add a new hours entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewHoursEntry(object sender, EventArgs e)
        {
            ViewModel.ShowFirstView();
        }
    }
}