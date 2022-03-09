using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main_Site.Models
{
    public class Country
    {
        public string CountryID { get; set; }
        public string CountryName { get; set; }
        public Game GameID { get; set; }
        public Sport SportID { get; set; }
    }
}
