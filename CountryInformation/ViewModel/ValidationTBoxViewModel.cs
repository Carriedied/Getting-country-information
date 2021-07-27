using CountryInformation.Model;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CountryInformation.ViewModel
{
    public abstract class ValidationTBoxViewModel : BindableBase, IDataErrorInfo
    {
        private readonly DelegateCommand submitCommand;
        private string _error;


        public string Error
        {
            get => _error;
            private set
            {
                if (SetProperty(ref _error, value))
                {
                    submitCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public string this[string columnName] => Error = Validate(columnName);


        public ICommand SubmitCommand => submitCommand;


        protected ValidationTBoxViewModel()
        {
            submitCommand = new DelegateCommand(Submit, () => string.IsNullOrEmpty(Error));
        }


        protected abstract string Validate(string columnName);

        protected abstract void APICountryInformation();

        protected abstract void Submit();
    }
}
