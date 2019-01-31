using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcpract
{
    class CountryController
    {
        public void CountryDetails(Country c)
        {
            CountryDetails cd = new CountryDetails(c);
            cd.Display();
        }

        internal void Display()
        {
            throw new NotImplementedException();
        }

        public void CountryMenu()
        {
            Console.WriteLine("what continet would you like to learn more about?");
            string input = Console.ReadLine();
            List<Country> countries;
            if (input.ToLower() == "north america")
            {
                NorthAmericaDB nadb = new NorthAmericaDB();
                countries = nadb.Countries;


            }
        }
    }
}
