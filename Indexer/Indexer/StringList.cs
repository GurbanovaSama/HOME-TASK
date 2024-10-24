using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class StringList
    {
        private string[] cities;

        public StringList(string[] cities)
        {
            this.cities = cities;
        }

        public int this[string cityName]
        {
            get
            {
                for (int i = 0; i < cities.Length; i++)
                {
                    if (cities[i] == cityName)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }

    }
}
