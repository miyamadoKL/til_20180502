using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Passengers per day at JR East stations in 2016
            var station = new[] {
                new { Name = "Shinjuku", Pref = "Tokyo", City_Ward = "Shinjuku", PassengersPerDay = 763907 },
                new { Name = "Ikebukuro", Pref = "Tokyo", City_Ward = "Toshima", PassengersPerDay = 559920 },
                new { Name = "Tokyo", Pref = "Tokyo", City_Ward = "Chiyoda", PassengersPerDay = 439554 },
                new { Name = "Yokohama", Pref = "Kanagawa", City_Ward = "Nishi_Yokohama", PassengersPerDay = 414683 },
                new { Name = "Shinagawa", Pref = "Tokyo", City_Ward = "Minato", PassengersPerDay = 371787 },
                new { Name = "Shibuya", Pref = "Tokyo", City_Ward = "Shibuya", PassengersPerDay = 371336 },
                new { Name = "Shimbashi", Pref = "Tokyo", City_Ward = "Minato", PassengersPerDay = 271028 },
                new { Name = "Omiya", Pref = "Saitama", City_Ward = "Omiya_Saitama", PassengersPerDay = 252769 },
                new { Name = "Akihabara", Pref = "Tokyo", City_Ward = "Chiyoda", PassengersPerDay = 246623 },
                new { Name = "Kitasenju", Pref = "Tokyo", City_Ward = "Adachi", PassengersPerDay = 214322 },
                new { Name = "Kawasaki", Pref = "Kanagawa", City_Ward = "Kawasaki_Kawasaki", PassengersPerDay = 209480 },
                new { Name = "Takadanobaba", Pref = "Tokyo", City_Ward = "Shinjuku", PassengersPerDay = 206683 },
                new { Name = "Ueno", Pref = "Tokyo", City_Ward = "Taito", PassengersPerDay = 182693 },
                new { Name = "Yurakucho", Pref = "Tokyo", City_Ward = "Chiyoda", PassengersPerDay = 169550 },
                new { Name = "Tachikawa", Pref = "Tokyo", City_Ward = "Tachikawa", PassengersPerDay = 165645 },
                new { Name = "Hamamatsucho", Pref = "Tokyo", City_Ward = "Minato", PassengersPerDay = 155294 },
                new { Name = "Tamachi", Pref = "Tokyo", City_Ward = "Minato", PassengersPerDay = 152624 },
                new { Name = "Nakano", Pref = "Tokyo", City_Ward = "Nakano", PassengersPerDay = 146400 },
                new { Name = "Kamata", Pref = "Tokyo", City_Ward = "Ota", PassengersPerDay = 144072 },
            };

            Console.WriteLine("Stations in Kanagawa order by PPDs ascending : "
                 + string.Join(", ", station.Where(x => x.Pref == "Kanagawa")
                    .OrderBy(x => x.PassengersPerDay).Select(x => x.Name))); // Kawasaki, Yokohama
            
            Console.WriteLine("The station most PPDs in Minato Ward : "
                + string.Join("", station.Where(x => x.Pref == "Tokyo" && x.City_Ward == "Minato")
                    .OrderByDescending(x => x.PassengersPerDay).Take(1).Select(x => x.Name))); // Shinagawa
                    
            Console.WriteLine("Total PPDs of stations group by Pref and City_Ward : "
                + string.Join(", ", station.GroupBy(x => new { x.Pref, x.City_Ward })
                    .Select(x => new { x.Key, sum = x.Sum(y => (int)y.PassengersPerDay) }).OrderBy(x => x.sum))); 
        }
    }
}
