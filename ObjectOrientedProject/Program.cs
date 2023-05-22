using System.Collections;
namespace ObjectOrientedProject;
class Program
{
    static void Main(string[] args)
    {
/*         Console.WriteLine("Hello, World!");

        Student sinchan = new Student(1,"sinchan",47,8.6434);
        Console.WriteLine(sinchan.Name);
        Console.WriteLine(sinchan.Gpa);  */
        
        Animal animal = new Animal();
        animal.Name = "generic";
        animal.Height = 50;
        animal.Weight = 4;
        animal.call();
        Animal dog = new Dog();
        dog.Name="tommy";
        dog.Height = 3;
        dog.Weight=70;
        dog.call();
        

        ArrayList ls = new ArrayList();
        ls.Add("tt");
        ls.Add(2);
        Console.WriteLine(ls.ToArray());
        Stack<int> st= new Stack<int>();
        st.Push(2);
        st.Push(4);
        st.Push(5);
        int popped = st.Pop();
        Console.WriteLine(popped);

    }
}
