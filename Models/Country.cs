using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace ADO.NET_HW_5.Models
{
    [Table(Name = "Countries")]
    internal class Country
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int ID { get; set; }

        [Column]
        public string CountryName { get; set; }

        [Column]
        public string CapitalName { get; set; }
        [Column]
        public int CountryResidentsAmount { get; set; }

        [Column]
        public float CountryArea { get; set; }

        [Column]
        public string Continent { get; set; }


        public string FullInfo { get => ToString(); }

        public override string ToString()
        {
            return $"Страна: {CountryName}\tСтолица: {CapitalName}\t" +
                   $"Количество жителей: {CountryResidentsAmount}\tПлощадь: {CountryArea}\tКонтинент: {Continent}";
        }
    }
}
