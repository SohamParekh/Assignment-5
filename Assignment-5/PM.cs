using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class PM
    {
        public PM(string pm_name,int pm_year)
        {
            this.pm_name = pm_name;
            this.pm_year = pm_year;
        }
        public string pm_name { get; set; }
        public int pm_year { get; set; }
        public override string ToString()
        {
            return "PrimeMinister Name:-" + pm_name + " " + "Year:-" + pm_year;
        }
    }
}
