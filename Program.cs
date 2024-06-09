//
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a = 4;
int b = 5;
if (a > 1)
{
if (b > 2)
{
int SUM = a + b;
Console.WriteLine(sum);
}
}

public partial class MainClass
{
    public double Add(double a, double b
        {
        return a + b;
    })
}
public partial class MainClass
{
    public double Add(double a, double b
        {
        return a - b;
    })
}
public partial class MainClass
{
    public double Add(double a, double b
        {
        return a * b;
    })
}
public partial class MainClass
{
    public double Add(double a, double b
        {
        return a / b;
    })
}
public partial class MainClass
{
    public double Add(double a, double b
        {
        return a * b;
    })
}
//

using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;

string r = "Rost";
string h = "hello";
if (r == h)
{
    Console.WriteLine("одинковые значения");
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
    public void Greet()
    {
        Console.WriteLine($"Привет, меня зовут {GetFullName()}.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите имя:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Введите фамилию:");
        string lastName = Console.ReadLine();
        Person person = new Person(firstName, lastName);
        person.Greet();
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string GetFullName()
    {
        Console.WriteLine($"{FirstName}");
        return $"{FirstName} {LastName}";
    }
    public string GetName()
    {
        Console.WriteLine($"{FirstName}");
        return FirstName;
    }

    public void Greet()
    {
        Console.WriteLine($"Привет, меня зовут {GetFullName()}.");
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        Person person = new Person("Тест", "Тестович");
        person.Greet();
    }
}
public class Human
{
    public string Blackeye { get; set; }
    public string Greyeye { get; set; }
    public string Greeneye { get; set; }
    public Human(string blackeye, string greyeye, string greeneye)
    {
        Blackeye = blackeye;
        Greyeye = greyeye;
        Greeneye = greeneye;
    }
    public string GetFullName()
    {
        return $"{Blackeye} {Greyeye} {Greeneye}";
    }
    public void Greet()
    {
        Console.WriteLine($"Привет, у человека бывает цвет глаз {GetFullName()}.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите цвет глаз тип 1:");
        string blackeye = Console.ReadLine();
        Console.WriteLine("Введите цвет глаз тип 2:");
        string greyeye = Console.ReadLine();
        Console.WriteLine("Введите цвет глаз тип 3:");
        string greeneye = Console.ReadLine();
        Person human = new Human(blackeye, greyeye, greeneye);
        human.Greet();
    }
}


public class Human
{
    public string Blackeye { get; set; }
    public string Greyeye { get; set; }
    public string Greeneye { get; set; }

    public Human(string blackeye, string greyeye, string greeneye)
    {
        Blackeye = blackeye;
        Greyeye = greyeye;
        Greeneye = greeneye;
    }

    public string GetFullName()
    {
        Console.WriteLine($"{Blackeye}");
        return $"{Blackeye} {Greyeye} {Greeneye}";
    }
    public string GetName()
    {
        Console.WriteLine($"{Blackeye}");
        return Blackeye;
    }

    public void Greet()
    {
        Console.WriteLine($"Привет, у человека бывает цвет глаз {GetFullName()}.");
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        Person person = new Human("разный", "с оттенками");
        person.Greet();
    }
}