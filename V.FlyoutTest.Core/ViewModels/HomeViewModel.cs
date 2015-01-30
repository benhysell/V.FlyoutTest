// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the HomeViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace V.FlyoutTest.Core.ViewModels
{
    /// <summary>
    /// Define the HomeViewModel type.
    /// </summary>
    public class HomeViewModel : BaseViewModel
    {
        //allows us to save state for Android
        public EnterTimeViewModel EnterTimeViewModelFragment;
        public CreateNewJobViewModel CreateNewJobViewModelFragment;

        public enum Section
        {
            Unknown,
            EnterTime,
            CreateNewJob
        }

        private List<MenuViewModel> menuItems;
        public List<MenuViewModel> MenuItems
        {
            get { return this.menuItems; }
            set { this.menuItems = value; this.RaisePropertyChanged(() => this.MenuItems); }
        }

        public HomeViewModel()
        {
            this.menuItems = new List<MenuViewModel>
                              {
                                  new MenuViewModel
                                      {
                                          Section = Section.EnterTime,
                                          Title = "Enter Time",
                                          ViewModelType = typeof(EnterTimeViewModel)
                                      },
                                  new MenuViewModel
                                      {
                                          Section = Section.CreateNewJob,
                                          Title = "Create New Job",
                                          ViewModelType = typeof(CreateNewJobViewModel)
                                      },                                 
                              };
        }

        private MvxCommand<MenuViewModel> m_SelectMenuItemCommand;
        public ICommand SelectMenuItemCommand
        {
            get
            {
                return this.m_SelectMenuItemCommand ?? (this.m_SelectMenuItemCommand = new MvxCommand<MenuViewModel>(this.ExecuteSelectMenuItemCommand));
            }
        }

        private void ExecuteSelectMenuItemCommand(MenuViewModel item)
        {
            //navigate if we have to, pass the id so we can grab from cache... or not
            switch (item.Section)
            {

                case Section.EnterTime:
                    this.ShowViewModel<EnterTimeViewModel>(new { item.Id });
                    break;
                case Section.CreateNewJob:
                    this.ShowViewModel<CreateNewJobViewModel>(new { item.Id });
                    break;                
            }

        }

        public Section GetSectionForViewModelType(Type type)
        {

            if (type == typeof(EnterTimeViewModel))
                return Section.EnterTime;

            if (type == typeof(CreateNewJobViewModel))
                return Section.CreateNewJob;

            return Section.Unknown;
        }
    }
}
