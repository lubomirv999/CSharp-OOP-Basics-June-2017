using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class Startup
{
    static void Main()
    {
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");

        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

        var numOfPeople = int.Parse(Console.ReadLine());
        var family = new Family();

        for (int i = 0; i < numOfPeople; i++)
        {
            var tokens = Console.ReadLine().Split(' ');
            var name = tokens[0];
            var age = int.Parse(tokens[1]);

            var person = new Person(name, age);
            family.AddMember(person);
        }

        var result = family.members.Where(p => p.Age > 30).OrderBy(p => p.Name);

        foreach (var person in result)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }

    public class Person
    {
        private string name;
        private int age;

        public int Age
        {
            get { return this.age; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public Person() : this("No name", 1)
        {
        }

        public Person(int Age) : this("No name", Age)
        {
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    public class Family
    {
        public List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.members.OrderByDescending(p => p.Age).FirstOrDefault();
        }
    }
}