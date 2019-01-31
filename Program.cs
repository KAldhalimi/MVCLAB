using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcpract
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController cc = new CountryController();
            cc.Display();
        }
        public static void CountryMenu()
        {
            bool runthis = true;
            while (runthis)
            {
                List<Country> countries;
                List<string> countryNames = new List<string>();
                string input = CountryMenuView.UserPick();
                if (input.ToLower() == "North America")
                {
                    NorthAmericaDB nadb = new NorthAmericaDB();
                    countries = nadb.Countries;
                    foreach (Country item in countries)
                    {
                        countryNames.Add(item.Name);
                        Console.WriteLine(item.Name);
                    }
                    Console.WriteLine("what country would you like ot learn about?");
                    string input2 = Console.ReadLine();
                    if (input2.ToLower() == "Usa")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "Mexico")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "Brazil")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "Peru")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "Canada")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    break;
                }
                else if (input.ToLower() == "asia")
                {
                    AsiaDB adb = new AsiaDB();
                    countries = adb.Countries;
                    foreach (Country c in countries)
                    {
                        countryNames.Add(c.Name);
                        Console.WriteLine(c.Name);
                    }
                    Console.WriteLine("what coutry would you like ot learn about?");
                    string input2 = Console.ReadLine();
                    if (input2.ToLower() == "China")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "India")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "Pakistan")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "Indonesia")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "SKorea")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }

                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}




        
    

