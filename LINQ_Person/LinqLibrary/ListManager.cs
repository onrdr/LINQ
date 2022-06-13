using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
    public class ListManager
    {
        public static List<Person> LoadSampleData()
        {
            List<Person> output = new()
            {
                new Person { FirstName = "Onur", LastName = "Derman", Birthday = Convert.ToDateTime("20/1/1987"), YearsExperience = 12},
                new Person { FirstName = "Yeliz", LastName = "Koç", Birthday = Convert.ToDateTime("21/2/2003"), YearsExperience = 2},
                new Person { FirstName = "Mehmet", LastName = "Kara", Birthday = Convert.ToDateTime("22/3/1977"), YearsExperience = 23},
                new Person { FirstName = "Ali", LastName = "Çelik", Birthday = Convert.ToDateTime("23/4/1981"), YearsExperience = 16},
                new Person { FirstName = "Gamze", LastName = "Adalı", Birthday = Convert.ToDateTime("24/5/1992"), YearsExperience = 8},
                new Person { FirstName = "Mine", LastName = "Kara", Birthday = Convert.ToDateTime("25/6/2002"), YearsExperience = 4}
            };

            return output;
        } 
    }
}
