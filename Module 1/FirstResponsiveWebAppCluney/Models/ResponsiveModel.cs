using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppCluney.Models
{
    public class ResponsiveModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string? Name { get; set; }
        public DateTime BirthYear { get; set; }
        public string AgeThisYear()
        {
            DateTime temp = DateTime.Now;
            DateTime endOfYear = new DateTime(temp.Year, 12, 31);
            int age = endOfYear.Year - BirthYear.Year;
            return String.Format("{0} will be {1} years old by December 31st of {2}",Name,age,endOfYear.Year);
        }
    }
}
