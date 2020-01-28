using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, PM> dict = new Dictionary<string, PM>();
            dict.Add("First", new PM("Atal Bihari Vajpayee", 1998));
            dict.Add("second", new PM("Narendra Modi", 2014));
            dict.Add("third", new PM("Manmohan Singh", 2004));
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nAdded Current PM of 2019 Election :-");
            dict["forth"] = new PM("Narendra Modi", 2019);
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nSorted By year :-");
            var sortyear = dict.OrderBy(d => d.Value.pm_year);
            foreach (var primeMini in sortyear)
                Console.WriteLine(primeMini);
            Console.Read();
        }
    }
}
