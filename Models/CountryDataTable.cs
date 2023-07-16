using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Configuration;
using System.Linq;
using MoreLinq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_HW_5.Models
{
    internal class CountryDataTable : DataContext 
    {
        public Table<Country> Countries => GetTable<Country>();
        public Func<List<string>> func;

        public CountryDataTable() :
            base(ConfigurationManager.ConnectionStrings["CountryDb"].ConnectionString)
        { }

        public void AddNewCountry(string countryName, string capitalName, int residentsAmount, float countryArea, string continent)
        {

            Country country = new Country()
            {
                CountryName = countryName,
                CapitalName = capitalName,
                CountryResidentsAmount = residentsAmount,
                CountryArea = countryArea,
                Continent = continent
            };
            Countries.InsertOnSubmit(country);
            SubmitChanges();
        }

        public void AddFunc()
        {
            func += Top5ByArea;
            func += Top5ByResidentsAmount;
            func += MaxAreaCountry;
            func += MaxAreaResidentsAmountCountry;
            func += SmallestAreaCountryInEurope;
            func += AverageAreaCountryInEurope;
            func += Top3Cities;
            func += CountriesAmount;
            func += ContinentMaxCountriesAmount;
            func += EachContinentCountriesAmount;
        }


        public List<string> Top5ByArea()
        {
            var res = from c in Countries
                      orderby c.CountryArea descending
                      select c.FullInfo;
            List<string> strings = new List<string>();
            int tmp = 5;
            foreach (var c in res) 
            {
                if (tmp > 0)
                    strings.Add(c);
                else
                    break;

                --tmp;
            }
            return strings;
        }

        public List<string> Top5ByResidentsAmount()
        {
            var res = from c in Countries
                      orderby c.CountryResidentsAmount descending
                      select c.FullInfo;

            List<string> strings = new List<string>();

            int tmp = 5;
            foreach (var c in res)
            {
                if (tmp > 0)
                    strings.Add(c);
                else
                    break;

                --tmp;
            }
            return strings;
        }

        public List<string>MaxAreaCountry()
        {
            List<string> strings = new List<string>();
            var res = Countries.MaxBy(a => a.CountryArea);

            foreach (var c in res)
                strings.Add(c.FullInfo);
            return strings;
        }

        public List<string> MaxAreaResidentsAmountCountry()
        {
            List<string> strings = new List<string>();
            var res = Countries.MaxBy(a => a.CountryResidentsAmount);

            foreach (var c in res)
                strings.Add(c.FullInfo);
            return strings;
        }

        public List <string> SmallestAreaCountryInEurope() 
        {
            var res = from c in Countries
                      where c.Continent.ToLower() == "євразія" 
                      select c;
            var minInEurope = res.MinBy(a => a.CountryArea);

            List<string> strings = new List<string>();
            foreach (var min in minInEurope)
                strings.Add(min.FullInfo);
            return strings;
        }

        public List<string> AverageAreaCountryInEurope()
        {
            var res = from c in Countries
                      where c.Continent.ToLower() == "євразія"
                      select c;
            List<string> strings = new List<string>
            {
                res.Average(a => a.CountryArea).ToString()
            };

            return strings;
        }

        public List<string> Top3Cities() => throw new NotImplementedException(); // У нас уже есть задание в котором нужно найти
                                                                                 // топ 5 стран по количеству жителей.
                                                                                 // Оставлю тут заглушку
                                                                                 // Если что это задание 7
        
        public List<string> CountriesAmount()
        {
            var res = from c in Countries
                      select c;
            List<string> strings = new List<string>() 
            {
                res.Count().ToString()
            };
            return strings;
        }

        public List<string> ContinentMaxCountriesAmount()
        {
            var res = from c in Countries
                      group c by c.Continent into g
                      orderby g.Key descending
                      select g.First();

            List<string> strings = new List<string>()
            {
                res.First().Continent
            };
            return strings;
        }

        public List<string> EachContinentCountriesAmount()
        {
            var res = from c in Countries
                      group c by c.Continent into g
                      orderby g.Count()
                      select g;

            List<string> strings = new List<string>();
            foreach (var c in res)
                strings.Add($"Continent: {c.Key}\tCount of countries: {c.Count()}");
            
            return strings;
        }


    }

}
