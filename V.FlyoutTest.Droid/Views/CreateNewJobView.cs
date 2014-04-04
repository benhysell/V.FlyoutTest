// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the CreateNewJobView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Android.Views;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;

namespace V.FlyoutTest.Droid.Views
{
    using Android.App;
    using Android.OS;

    public class CreateNewJobView : MvxFragment
    {
        public CreateNewJobView()
        {
            this.RetainInstance = true;
        }

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            this.HasOptionsMenu = true;
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.CreateNewJobView, null);
        }

        public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
        {
            inflater.Inflate(Resource.Menu.refresh, menu);
        }
    }
}