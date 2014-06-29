// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the FirstView.xaml type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using V.FlyoutTest.Core.ViewModels;

namespace V.FlyoutTest.WindowsPhone.Views
{
    /// <summary>
    ///    Defines the FirstView.xaml type.
    /// </summary>
    public partial class HomeView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirstView"/> class.
        /// </summary>
        public HomeView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (null == ViewModel)
            {
                base.OnNavigatedTo(e);

                var selectedItem = ((HomeViewModel)ViewModel).MenuItems.FirstOrDefault(x => x.Title == "Enter Time");
                if (null != selectedItem)
                    ((HomeViewModel)ViewModel).SelectMenuItemCommand.Execute(selectedItem);
            }
        }

        private void UIElement_OnTap(object sender, GestureEventArgs e)
        {
            var selectedItem = ((HomeViewModel)ViewModel).MenuItems.FirstOrDefault(x => x.Title == ((TextBlock)sender).Text);
            if (null != selectedItem)
                ((HomeViewModel)ViewModel).SelectMenuItemCommand.Execute(selectedItem);
        }
    }
}