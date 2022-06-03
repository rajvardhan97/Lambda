using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    public class Program
    {
        public static void Main(String[] args)
        {
            List<Person> PeopleList = new List<Person>();
            PeopleList.Add(new Person(2, "Harsh", "RJ", 17));
            PeopleList.Add(new Person(1, "Ram", "UP", 22));
            PeopleList.Add(new Person(8, "Akshay", "Punjab", 44));
            PeopleList.Add(new Person(21, "Arpita", "UK", 77));
            PeopleList.Add(new Person(19, "Raj", "HP", 30));
            PeopleList.Add(new Person(5, "Shantanu", "Bihar", 62));

            Console.WriteLine("Retrieve top 2 records with age less than 60");
            foreach (Person p in PeopleList.FindAll(e => (e.age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: " + p.name + " Age: " + p.age);
            }

            Console.WriteLine("\nRetrieve all record with age between 13 & 18");
            foreach (Person p in PeopleList.FindAll(e => (e.age >= 13 && e.age <= 18)).ToList())
            {
                Console.WriteLine("Name: " + p.name);
            }

            Console.WriteLine("\nRetrieve average age in the list");
            double Average = PeopleList.Average(e => e.age);
            Console.WriteLine("Average Age is: " + Average);

            Console.WriteLine("\nCheck for specific name present in the list or not");
            string NAME = Console.ReadLine();
            if (PeopleList.Exists(e => e.name == NAME))
            {
                Console.WriteLine(NAME + " Exist in the list");
            }

            Console.WriteLine("\nSkip record from the list for age is less than 60");
            foreach(Person person in PeopleList.SkipWhile(e => e.age < 60))
            {
                Console.WriteLine("Name: " + person.name + " Age: " + person.age);
            }
        }
    }
}