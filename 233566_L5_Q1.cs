using System;

public enum Department
{
    CSE,
    CS,
    ME
}

public class Person
{
    private string name;

    public Person()
    {
        this.name = null;
    }

    public Person(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

public class Student : Person
{
    private string regNo;
    private int age;
    private Department program;

    public Student()
    {
        this.regNo = null;
        this.age = 0;
        this.program = Department.CSE;
    }

    public Student(string name, string regNo, int age, Department program) : base(name)
    {
        this.regNo = regNo;
        this.age = age;
        this.program = program;
    }

    public string RegNo
    {
        get { return regNo; }
        set { regNo = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Department Program
    {
        get { return program; }
        set { program = value; }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person("Muhammad Ahmad Ijaz");


        Student student = new Student("Muhammad Ahmad Ijaz", "233566", 20, Department.CS);


        Console.WriteLine("Person Details:");
        Console.WriteLine("Name: " + person.Name);

        Console.WriteLine("\nStudent Details:");
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("RegNo: " + student.RegNo);
        Console.WriteLine("Age: " + student.Age);
        Console.WriteLine("Program: " + student.Program);
    }
}