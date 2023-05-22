namespace ObjectOrientedProject;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Student sinchan = new Student(1,"sinchan",47,8.6434);
        Console.WriteLine(sinchan.Name);
        Console.WriteLine(sinchan.Gpa);

    }
}
