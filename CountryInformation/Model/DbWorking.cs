using CountryInformation.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CountryInformation.Model
{
    public class DbWorking
    {
        public void AddToDb(string CityCapital, string RegionRegion, string name, string code, double area, int population)
        {
            City newCity = new();
            Region newRegion = new();

            using (ApplicationContext db = new())
            {
                bool checkExistCityId = db.DbCountry.Any(el => el.Id == 1);

                if (checkExistCityId)
                {
                    bool checkCityIsExist = db.DbCity.Any(el => el.Name == CityCapital);
                    if (!checkCityIsExist)
                    {
                        newCity = new() { Name = CityCapital };
                        db.DbCity.Add(newCity);
                        db.SaveChanges();
                    }

                    bool checkRegionIsExist = db.DbRegion.Any(el => el.Name == RegionRegion);
                    if (!checkRegionIsExist)
                    {
                        newRegion = new() { Name = RegionRegion };
                        db.DbRegion.Add(newRegion);
                        db.SaveChanges();
                    }
                }

                bool checkExistCountryId = db.DbCountry.Any(el => el.Id == 1);

                if (checkExistCountryId)
                {
                    bool checkExistCountry = db.DbCountry.Any(el => el.Code == code);

                    if (!checkExistCountry)
                    {
                        Country newCountry = new()
                        {
                            Name = name,
                            Code = code,
                            Capital = newCity,
                            CapitalName = CityCapital,
                            Area = area,
                            Population = population,
                            Region = newRegion,
                            RegionName = RegionRegion
                        };

                        db.DbCountry.Add(newCountry);
                        db.SaveChanges();
                        MessageBox.Show("Информация о стране сохранена в базу данных");
                    }
                    else
                    {
                        //CreateCity(CityCapital);
                        //CreateRegion(RegionRegion);

                        var UpdateCountry = db.DbCountry.FirstOrDefault(p => p.Code == code);

                        UpdateCountry.Name = name;
                        UpdateCountry.Code = code;
                        UpdateCountry.CapitalName = CityCapital;
                        UpdateCountry.Area = area;
                        UpdateCountry.Population = population;
                        UpdateCountry.RegionName = RegionRegion;

                        db.SaveChanges();

                        MessageBox.Show("Информация в базе данных обновлена");
                    }
                }
                else
                {
                    newCity = new() { Name = CityCapital };
                    db.DbCity.Add(newCity);
                    db.SaveChanges();

                    newRegion = new() { Name = RegionRegion };
                    db.DbRegion.Add(newRegion);
                    db.SaveChanges();

                    Country newCountry = new()
                    {
                        Name = name,
                        Code = code,
                        Capital = newCity,
                        CapitalName = CityCapital,
                        Area = area,
                        Population = population,
                        Region = newRegion,
                        RegionName = RegionRegion
                    };

                    db.DbCountry.Add(newCountry);
                    db.SaveChanges();

                    //CreateCity(CityCapital);
                    //CreateRegion(RegionRegion);

                    MessageBox.Show("Информация о стране сохранена в базу данных");
                }
            }
        }

        public void CreateCity(string NameCity)
        {
            City newCity = new();

            using (ApplicationContext db = new())
            {
                newCity = new() { Name = NameCity };
                db.DbCity.Add(newCity);
                db.SaveChanges();
            }
        }

        public void CreateRegion(string NameRegion)
        {
            Region newRegion = new();
            using (ApplicationContext db = new())
            {
                newRegion = new() { Name = NameRegion };
                db.DbRegion.Add(newRegion);
                db.SaveChanges();
            }
        }
    }
}
