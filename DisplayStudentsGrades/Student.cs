 class Student
{
    public string FullName { get; set; }
    public char Sex { get; set; }
    public float Midterm { get; set; }
    public float Final { get; set; }
    public float Average => Midterm * 0.4F + Final * 0.6F; 
    public override string ToString() => $"{FullName} : Mid: {Midterm}, Final: {Final}, Average: {Average}"; 
}