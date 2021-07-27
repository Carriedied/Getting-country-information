using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace CountryInformation.Model
{
    public partial class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CityInfoKey { get; set; }
        [ForeignKey("CityInfoKey")]
        public virtual City Capital { get; set; }
        public string CapitalName { get; set; }
        public double Area { get; set; }
        public int Population { get; set; }
        public int RegionInfoKey { get; set; }
        [ForeignKey("RegionInfoKey")]
        public virtual Region Region { get; set; }
        public string RegionName { get; set; }
    }
}
