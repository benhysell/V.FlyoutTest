// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the AddHoursEntryView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace V.FlyoutTest.Droid.Views
{
    using Android.App;
    using Android.OS;

    /// <summary>
    /// Defines the AddHoursEntryView type.
    /// </summary>
    [Activity(Label = "View for AddHoursEntryView")]
    public class AddHoursEntryView : BaseView
    {
        /// <summary>
        /// Called when [create].
        /// </summary>
        /// <param name="bundle">The bundle.</param>
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.SetContentView(Resource.Layout.AddHoursEntryView);
        }
    }
}