

var list = new List<Student>()
{
    new Student () { FullName = "Onur", Gender = 'M', Midterm = 50, Final = 40 },
    new Student () { FullName = "Kübra", Gender = 'F', Midterm = 60, Final = 50 },
    new Student () { FullName = "Celalettin", Gender = 'M', Midterm = 70, Final = 60 },
    new Student () { FullName = "Ziya", Gender = 'M', Midterm = 80, Final = 70 },
    new Student () { FullName = "İsmail", Gender = 'M', Midterm = 90, Final = 80 },
    new Student () { FullName = "Büşra", Gender = 'F', Midterm = 100, Final = 90 }
};  


Console.WriteLine("All Student List Ordered By Full Name:");
list.OrderBy(f => f.FullName).ToList().ForEach(s => DisplayInfo(s)); 

Console.WriteLine("\nFemale Students List :");
list.Where(fs => fs.Gender == 'F').ToList().ForEach(fs => DisplayInfo(fs)); 

Console.WriteLine("\nMale Students List :");
list.Where(ms => ms.Gender == 'M').ToList().ForEach(ms => DisplayInfo(ms)); 

Console.WriteLine("\nPassed List:");
list.Where(ps => ps.Average >= 75).ToList().ForEach(ps => DisplayInfo(ps)); 

Console.WriteLine("\nFailed List :");
list.Where(fs => fs.Average < 75).ToList().ForEach(fs => DisplayInfo(fs)); 

Console.WriteLine("\nPassed Female List:");
list.Where(pfs => pfs.Average >= 75 && pfs.Gender == 'F').ToList().ForEach(pfs => DisplayInfo(pfs)); 

Console.WriteLine("\nPassed Male List:");
list.Where(pms => pms.Average >= 75 && pms.Gender == 'M').ToList().ForEach(pms => DisplayInfo(pms)); 

Console.WriteLine("\nFailed Female List :");
list.Where(ffs => ffs.Average < 75 && ffs.Gender == 'F').ToList().ForEach(ffs => DisplayInfo(ffs)); 

Console.WriteLine("\nFailed Male List :");
list.Where(fms => fms.Average < 75 && fms.Gender == 'M').ToList().ForEach(fms => DisplayInfo(fms));  



Console.ReadKey();


static void DisplayInfo(Student s)
{
    Console.WriteLine(s.ToString());
}