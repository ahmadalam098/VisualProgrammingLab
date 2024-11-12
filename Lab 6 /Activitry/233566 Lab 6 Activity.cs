/*
using System;
using System.Collections.Generic;

class GenericListActivity
{
    static void Main()
    {

       List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);

        Console.WriteLine("Original list");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        numbers.Remove(3);
        Console.WriteLine("List after removal");
        foreach(int i in numbers)
        {
            Console.WriteLine(i);
        }

        numbers.Sort();
        Console.WriteLine("List after Sorted");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}


// Activity 2
using System;
using System.Collections.Generic;

class DictionaryActivity
{
    static void Main()
    {
        Dictionary<string,string> countries = new Dictionary<string,string>();

        countries["USA"] = "Wishigtion ,D.c";
        countries["France"] = "Paris ";
        countries["Japan"] = "Tokyo";
        countries["India"] = "New Delhi";

        Console.WriteLine("Countries and Capiotals");
        foreach (var pair in countries)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }

        Console.WriteLine($"\n Capital of Japan is: {countries["Japan"]}");

        countries.Remove("France");

        Console.WriteLine("Update: ");
        foreach(var pair in countries)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }
    }
}


// Activity 3
using System;
using System.Collections;

class NonGenericActivity
{
    static void Main()
    {
        ArrayList arrayList = new ArrayList();

        arrayList.Add(10);
        arrayList.Add("Hello");
        arrayList.Add(20.5);
        arrayList.Add("World");


        Console.WriteLine("Array list HAve" );
        foreach (var i in arrayList)
        {
            Console.WriteLine(i);
        }

        arrayList.Remove("Hello");

        Console.WriteLine("Updated Array list HAve");
        foreach (var i in arrayList)
        {
            Console.WriteLine(i);
        }
    }
}
*/

// Activity 4
using System;
using System.Collections;
//using System.Linq;

class StudentsManagementSystem
{
    static void Main()
    {
        Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();

        students["Alice"] = new List<int> { 85, 90, 88 };
        students["Bob"] = new List<int> { 70, 60, 75 };
        students["Charile"] = new List<int> { 95, 94, 92 };
        students["Dairy"] = new List<int> { 55, 60, 58 };

        Console.WriteLine("Student Avereage");
        foreach (var student in students)
        {
            double average = student.Value.Average();
            Console.WriteLine($"{student.Key} : {average:F2}");
        }


        var topStudent = students.OrderByDescending(s => s.Value.Average()).First();
        var lowStudent = students.OrderBy(s => s.Value.Average()).First();

        Console.WriteLine($" Top performing Student : {topStudent.Key} with averege of {topStudent.Value.Average():F2}");
        Console.WriteLine($" Low performing Student : {lowStudent.Key} with averege of {lowStudent.Value.Average():F2}");

        //remove
        var fallStudent = students.Where(s=>s.Value.Average() <60).Select(s=>s.Key).ToList();
        foreach (var student in fallStudent)
        {
            students.Remove(student);
        }

        //Display
        Console.WriteLine("After removal");
        foreach(var student in students)
        {
              Console.WriteLine(student.Key);
        }
    }
}