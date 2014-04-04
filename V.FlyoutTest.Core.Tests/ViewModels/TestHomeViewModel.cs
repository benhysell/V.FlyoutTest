// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the TestTestHomeViewModelModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace V.FlyoutTest.Core.Tests.ViewModels
{
    using Core.ViewModels;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Defines the TestTestHomeViewModelModel type.
    /// </summary>
    [TestClass]
    public class TestTestHomeViewModelModel : BaseTest
    {
        /// <summary>
        /// The HomeViewModel model.
        /// </summary>
        private HomeViewModel homeViewModel;

        /// <summary>
        /// Creates an instance of the object to test.
        /// To allow Ninja automatically create the unit tests
        /// this method should not be changed.
        /// </summary>
        public override void CreateTestableObject()
        {
            this.homeViewModel = new HomeViewModel();
        }
    }
}
