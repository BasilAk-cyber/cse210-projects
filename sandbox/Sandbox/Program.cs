using System;
using System.IO;

class Person
{
    public double _height;
    public int _age;
    public string _name;

    public Person (double height, int age, string name)
    {
        _height = height;
        _age = age;
        _name = name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Person> person = new List<Person>();

        Person john = new Person(180, 18, "john");
        Person mark = new Person(200, 26, "mark");

        person.Add(john);
        person.Add(mark);

        

        using (StreamWriter OutputFile = new StreamWriter("person.txt"))
        {
            foreach(Person people in person)
            {
                OutputFile.WriteLine($"Name:{people._name}");
                OutputFile.WriteLine($"Age:{people._age}");
                OutputFile.WriteLine($"Height:{people._height}");
            }
        }

        
       /*  /* Blind kitchen = new Blind();
        kitchen._height = 12;
        kitchen._width = 8;
        kitchen._color = "Blue"; */

       /*  Blind livingRoom = new Blind(18, 12, "Green");
        Blind kitchen = new Blind(18, 12, "Green");

        House johnsonHouse = new House(kitchen); */
        /* livingRoom._height = 18;
        livingRoom._width = 12;
        livingRoom._color = "Green"; */

       // House johnsonHouse = new House();

        /* johnsonHouse._blinds.Add(kitchen);
        johnsonHouse._blinds.Add(livingRoom); */
       // johnsonHouse.AddBlind(kitchen);
        //johnsonHouse.DisplayBlinds(); 
    }
}