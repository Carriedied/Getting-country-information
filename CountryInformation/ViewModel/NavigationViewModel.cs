using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CountryInformation.ViewModel
{
    class NavigationViewModel : BindableBase
    {
        public ICommand EmpCommand { get; set; }

        public ICommand DeptCommand { get; set; }

        private object selectedViewModel;

        public object SelectedViewModel
        {
            get { return selectedViewModel; }
            set { selectedViewModel = value; RaisePropertyChanged(nameof(SelectedViewModel)); }
        }

        public NavigationViewModel()
        {
            EmpCommand = new DelegateCommand(OpenEmp);
            DeptCommand = new DelegateCommand(OpenDept);
        }

        private void OpenEmp()
        {
            SelectedViewModel = new CountryInformationViewModel();
        }

        private void OpenDept()
        {
            SelectedViewModel = new AllCountriesInformationViewModel();
        }
    }
}
