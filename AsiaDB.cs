using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcpract
{
    class AsiaDB
    {
        public List<Country> Countries= new List<Country>();

        public AsiaDB()
        {
            string[] ChinaColors = { "Red", "Gold", };
            Countries.Add(new Country("China", "Mandarin", "ni hao shijie", ChinaColors));
            string[] IndiaColors = { "White", "Green" };
            Countries.Add(new Country("India", "Hindu", "Hindu Shakti", IndiaColors));
            string[] IndonesiaColors = { "Red", "White" };
            Countries.Add(new Country("Indonesia", "indonease", "whatsup", IndonesiaColors));
            string[] SKoreaColors = { "Red", "White", "Blue" };
            Countries.Add(new Country("SKorea", "mandarian", "ni hao shijie", SKoreaColors));
            string[] PakistanColors = { "Green", "White", "Red" };
            Countries.Add(new Country("Pakistan", "Urdu", "Acchi Shaam", PakistanColors));

        }
    }
}
