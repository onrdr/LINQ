

var list = new List<Student>()
{
    new Student () { FullName = "Onur", Sex = 'M', Midterm = 50, Final = 40 },
    new Student () { FullName = "Kübra", Sex = 'F', Midterm = 60, Final = 50 },
    new Student () { FullName = "Celalettin", Sex = 'M', Midterm = 70, Final = 60 },
    new Student () { FullName = "Ziya", Sex = 'M', Midterm = 80, Final = 70 },
    new Student () { FullName = "İsmail", Sex = 'M', Midterm = 90, Final = 80 },
    new Student () { FullName = "Büşra", Sex = 'F', Midterm = 100, Final = 90 }
}; 

// ****************************************************
Console.WriteLine("All Student List Ordered By Full Name:");
list.OrderBy(f => f.FullName)
    .ToList()
    .ForEach(s => Console.WriteLine(s.ToString()));
// ****************************************************

Console.WriteLine("\nFemale Students List :");
list.Where(f => f.Sex == 'F')
    .ToList()
    .ForEach(f => Console.WriteLine(f.ToString()));
// ****************************************************

Console.WriteLine("\nMale Students List :");
list.Where(m => m.Sex == 'M')
    .ToList()
    .ForEach(m => Console.WriteLine(m.ToString()));
// ****************************************************

Console.WriteLine("\nPassed List:");
list.Where(s => s.Average >= 75)
    .ToList()
    .ForEach(s => Console.WriteLine(s.ToString()));
// ****************************************************

Console.WriteLine("\nFailed List :");
list.Where(s => s.Average < 75)
    .ToList()
    .ForEach(s => Console.WriteLine(s.ToString()));
// ****************************************************

Console.WriteLine("\nPassed Female List:");
list.Where(s => s.Average >= 75 && s.Sex == 'F')
    .ToList()
    .ForEach(s => Console.WriteLine(s.ToString()));
// ****************************************************

Console.WriteLine("\nPassed Male List:");
list.Where(s => s.Average >= 75 && s.Sex == 'M')
    .ToList()
    .ForEach(s => Console.WriteLine(s.ToString()));
// ****************************************************

Console.WriteLine("\nFailed Female List :");
list.Where(s => s.Average < 75 && s.Sex == 'F')
    .ToList()
    .ForEach(s => Console.WriteLine(s.ToString()));
// ****************************************************

Console.WriteLine("\nFailed Male List :");
list.Where(s => s.Average < 75 && s.Sex == 'M')
    .ToList()
    .ForEach(s => Console.WriteLine(s.ToString()));
// ****************************************************
 
Console.ReadKey();
