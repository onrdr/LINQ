using Linq_Library;
 

List<Person> people = ListManager.LoadSampleData();

#region Order By
// Order By Last Name Ascending
var people1 = people.OrderBy(x => x.LastName).ToList();
Print("Order by LastName ", people1);

// Order By Last Name Descending
var people2 = people.OrderByDescending(x => x.LastName).ToList();
Print("Order by LastName descending ", people2);

// First Order By LastName Descending and then Order By YearsExperience Ascending
var people3 = people.OrderByDescending(x => x.LastName).ThenBy(x => x.YearsExperience).ToList();
Print("Order by LastName descending and then YearsExperience ascending ", people3);

// First Order By LastName Descending and then Order By YearsExperience Descending 
var people4 = people.OrderByDescending(x => x.LastName).ThenByDescending(x => x.YearsExperience).ToList();
Print("Order by LastName descending and then YearsExperience descending ", people4);
#endregion


#region Where
// List of people that has YearExperince less than 9
var people5 = people.Where(x => x.YearsExperience < 9).ToList();
Print("Using where with experience smaller than 9", people5);
 
// List of people that has YearExperince more than 9 and borned in march
var people6 = people.Where(x => x.YearsExperience > 9 && x.Birthday.Month == 3).ToList();
Print("Using where with experience bigger than 9 and birthday month is march", people6);
#endregion


#region Sum
// The sum of the YearsExperience of all the people in the people list 
int yearsTotal = people.Sum(x => x.YearsExperience);
Console.WriteLine($"The total years of experince of all the people is {yearsTotal}\n");
 
// The sum of the YearsExperience of all the people who borned in march (chained methods => where and sum)
yearsTotal = people.Where(x => x.Birthday.Month == 3).Sum(x => x.YearsExperience); 
Console.WriteLine($"The total years of experince of the people who borned in march is {yearsTotal}");
#endregion

 

Console.ReadLine();

static void Print(string heading, List<Person> list)
{
    Console.WriteLine($"{heading}"); 
    Console.ForegroundColor = ConsoleColor.Green; 
    list.ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} ({x.Birthday.ToShortDateString()}) " +
                                        $": Experience {x.YearsExperience}")); 
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine();
}

Console.ReadLine();
