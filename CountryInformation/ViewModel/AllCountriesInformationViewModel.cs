using CountryInformation.Model;
using CountryInformation.Model.Data;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CountryInformation.ViewModel
{
    public class AllCountriesInformationViewModel : BindableBase
    {
        public ICommand ShowAllCountries { get; set; }

        public ObservableCollection<Country> Countries { get; } = new();

        public void ShowCountry()
        {
            using (ApplicationContext db = new())
            {
                foreach(var item in db.DbCountry)
                {
                    Countries.Add(new Country()
                    {
                        Name = item.Name,
                        Code = item.Code,
                        CapitalName = item.CapitalName,
                        Area = item.Area,
                        Population = item.Population,
                        RegionName = item.RegionName
                    });
                }
            }      
        }

        public AllCountriesInformationViewModel()
        {
            ShowAllCountries = new DelegateCommand(ShowCountry);
        }
    }
}
