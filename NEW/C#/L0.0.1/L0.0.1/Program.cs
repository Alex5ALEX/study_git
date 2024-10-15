

namespace test;


class Program
{
    static void Main(string[] args)
    {
        int a = 0;
        var Joe = new Person();
        Joe.name = "Joe";
        Joe.age = 18;
        Joe.print();

    }
}




class Person
{
    public int age;
    public string name;

    public void print()
    {
        Console.WriteLine($"Name : {name}, age : {age}");
    }
}