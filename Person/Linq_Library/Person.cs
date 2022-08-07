 

namespace Linq_Library
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearsExperience { get; set; }
        public DateTime Birthday { get; set; }
        public string FullName => $"{FirstName} {LastName}"; 
    }
} 
