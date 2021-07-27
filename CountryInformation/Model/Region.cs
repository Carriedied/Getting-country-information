using System;
using System.Collections.Generic;

#nullable disable

namespace CountryInformation.Model
{
    public partial class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}
