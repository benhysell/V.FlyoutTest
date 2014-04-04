// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the TestTestEnterTimeViewModelModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace V.FlyoutTest.Core.Tests.ViewModels
{
    using Core.ViewModels;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Defines the TestTestEnterTimeViewModelModel type.
    /// </summary>
    [TestClass]
    public class TestTestEnterTimeViewModelModel : BaseTest
    {
        /// <summary>
        /// The EnterTimeViewModel model.
        /// </summary>
        private EnterTimeViewModel enterTimeViewModel;

        /// <summary>
        /// Creates an instance of the object to test.
        /// To allow Ninja automatically create the unit tests
        /// this method should not be changed.
        /// </summary>
        public override void CreateTestableObject()
        {
            this.enterTimeViewModel = new EnterTimeViewModel();
        }
    }
}
