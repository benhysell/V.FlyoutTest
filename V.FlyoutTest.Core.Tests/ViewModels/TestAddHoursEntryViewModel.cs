// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the TestTestAddHoursEntryViewModelModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace V.FlyoutTest.Core.Tests.ViewModels
{
    using Core.ViewModels;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Defines the TestTestAddHoursEntryViewModelModel type.
    /// </summary>
    [TestClass]
    public class TestTestAddHoursEntryViewModelModel : BaseTest
    {
        /// <summary>
        /// The AddHoursEntryViewModel model.
        /// </summary>
        private AddHoursEntryViewModel addHoursEntryViewModel;

        /// <summary>
        /// Creates an instance of the object to test.
        /// To allow Ninja automatically create the unit tests
        /// this method should not be changed.
        /// </summary>
        public override void CreateTestableObject()
        {
            this.addHoursEntryViewModel = new AddHoursEntryViewModel();
        }
    }
}
