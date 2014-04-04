using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.FlyoutTest.Core.ViewModels
{
    public class MenuViewModel : BaseViewModel 
    {
        private HomeViewModel.Section section;
        public HomeViewModel.Section Section
        {
            get { return this.section; }
            set
            {
                this.section = value;
                this.Id = (int)this.section; this.RaisePropertyChanged(() => this.Section);
            }
        }

        public Type ViewModelType;
    }
}
