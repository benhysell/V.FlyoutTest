// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the TestTestCreateNewJobViewModelModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace V.FlyoutTest.Core.Tests.ViewModels
{
    using Core.ViewModels;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Defines the TestTestCreateNewJobViewModelModel type.
    /// </summary>
    [TestClass]
    public class TestTestCreateNewJobViewModelModel : BaseTest
    {
        /// <summary>
        /// The CreateNewJobViewModel model.
        /// </summary>
        private CreateNewJobViewModel createNewJobViewModel;

        /// <summary>
        /// Creates an instance of the object to test.
        /// To allow Ninja automatically create the unit tests
        /// this method should not be changed.
        /// </summary>
        public override void CreateTestableObject()
        {
            this.createNewJobViewModel = new CreateNewJobViewModel();
        }
    }
}
