using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class City
    {
        //tu bedzie polaczenie z baza 

        public string Description { get; set; }
        public List<string> Places { get; set; }
        public string ImageLink { get; set; }
        public bool Favourites { get; set; }
        public string Transport { get; set; }
        public string Hotels { get; set; }
        public string Restaurants { get; set; }
        public int CityId { get; set; }
        //zapytanie do bazy danych
        public string Name { get; set; }
        public City(string name)
        {



        }
    }
}
