// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the EnterTimeView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Android.Support.V4.View;
using Android.Views;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;
using V.FlyoutTest.Core.ViewModels;

namespace V.FlyoutTest.Droid.Views
{
    using Android.App;
    using Android.OS;

    /// <summary>
    /// Defines the EnterTimeView type.
    /// </summary>    
    public class EnterTimeView : MvxFragment
    {
        public EnterTimeView()
        {
            this.RetainInstance = true;
        }

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
          this.HasOptionsMenu = true;
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.EnterTimeView, null);
        }

        public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
        {
            inflater.Inflate(Resource.Menu.refresh, menu);
        }
        
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            var viewModel = ViewModel as EnterTimeViewModel;
            viewModel.ShowFirstView();
            return true;
        }
    }
}