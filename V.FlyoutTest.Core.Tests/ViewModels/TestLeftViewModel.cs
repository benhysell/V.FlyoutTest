// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the TestTestLeftViewModelModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace V.FlyoutTest.Core.Tests.ViewModels
{
    using Core.ViewModels;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Defines the TestTestLeftViewModelModel type.
    /// </summary>
    [TestClass]
    public class TestTestLeftViewModelModel : BaseTest
    {
        /// <summary>
        /// The LeftViewModel model.
        /// </summary>
        private LeftViewModel leftViewModel;

        /// <summary>
        /// Creates an instance of the object to test.
        /// To allow Ninja automatically create the unit tests
        /// this method should not be changed.
        /// </summary>
        public override void CreateTestableObject()
        {
            this.leftViewModel = new LeftViewModel();
        }
    }
}
