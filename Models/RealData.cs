using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApp.Models
{
    public class RealData
    {
        public string Message { get; set; }
        public GlobalData Global { get; set; }
        public List<CountryInfo> Countries { get; set; }
    }
    public struct GlobalData
    {
        public double NewConfirmed;
        public double TotalConfirmed;
        public double NewDeaths;
        public double TotalDeaths;
        public double NewRecovered;
        public double TotalRecovered;
    }
    public struct CountryInfo
    {
        public string Country;
        public string CountryCode;
        public string Slug;
        public double NewConfirmed;
        public double TotalConfirmed;
        public double NewDeaths;
        public double TotalDeaths;
        public double NewRecovered;
        public double TotalRecovered;
        public string Date;
    }
}
