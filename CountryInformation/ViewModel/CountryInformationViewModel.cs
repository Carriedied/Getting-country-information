using CountryInformation.Model;
using Newtonsoft.Json.Linq;
using Prism.Commands;
using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using System.Windows.Input;

namespace CountryInformation.ViewModel
{
    public class CountryInformationViewModel : ValidationTBoxViewModel
    {
        public ICommand SearchCommand { get; set; }
        public ICommand AddToDbCommand { get; set; }

        Country country = new();
        public DbWorking modelDb = new();

        private string text;

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        protected override string Validate(string columnName)
        {
            switch (columnName)
            {
                case nameof(Text):
                    if (string.IsNullOrEmpty(Text))
                        return "Введите название страны.";
                    else
                    {
                        foreach (char c in Text)
                        {
                            if (!Char.IsLetter(c))
                                return "Введите название страны.";
                        }
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(columnName), columnName, null);
            }

            return string.Empty;
        }

        private ObservableCollection<Country> countries { get; set; }
        public ObservableCollection<Country> Countries
        {
            get { return countries; }
            set
            {
                countries = value; RaisePropertyChanged(nameof(countries));
            }
        }

        protected override void APICountryInformation()
        {
            int symbolOpen = 0, symbolClose = 0;

            try
            {
                string requestUri = "https://restcountries.eu/rest/v2/name/" + Text;

                WebClient syncClient = new();

                var content = syncClient.DownloadString(requestUri);

                content = content.TrimStart(new char[] { '[' }).TrimEnd(new char[] { ']' });
                
                for (int i = 0; i < content.Length; i++)
                {
                    if (content[i] == '[')
                        symbolOpen++;

                    if (content[i] == ']')
                        symbolClose++;

                    if (symbolOpen == 2)
                    {
                        content = content.Remove(i, 1);
                        symbolOpen++;
                    }

                    if (symbolClose == 2)
                    {
                        content = content.Remove(i, 1);
                        symbolClose++;
                    }
                }

                var json = JObject.Parse(content);

                ObservableCollection<Country> temp = new()
                {
                    new()
                    {
                        Name = (string)json["name"],
                        Code = (string)json["callingCodes"],
                        CapitalName = (string)json["capital"],
                        Area = (double)json["area"],
                        Population = (int)json["population"],
                        RegionName = (string)json["region"]
                    }
                };

                Countries = temp;

                country = new()
                {
                    Name = (string)json["name"],
                    Code = (string)json["callingCodes"],
                    CapitalName = (string)json["capital"],
                    Area = (double)json["area"],
                    Population = (int)json["population"],
                    RegionName = (string)json["region"]
                }; 
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        public bool myVisibility;

        public bool MyVisibility
        {
            get { return myVisibility; }
            set { myVisibility = value; RaisePropertyChanged(nameof(MyVisibility)); }
        }

        protected override void Submit()
        {
            MyVisibility = true;

            APICountryInformation();
        }

        public void AddToDb()
        {
            modelDb.AddToDb(country.CapitalName, country.RegionName, country.Name, country.Code, country.Area, country.Population);
        }

        public CountryInformationViewModel()
        {
            SearchCommand = new DelegateCommand(Submit);
            AddToDbCommand = new DelegateCommand(AddToDb);
        }
    }
}
