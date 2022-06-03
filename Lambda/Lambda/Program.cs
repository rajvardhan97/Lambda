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
            PeopleList.Add(new Person(5, "Shantanu", "Bihar", 62));
            PeopleList.Add(new Person(4, "Raj", "HP", 22));

            Console.WriteLine("Retrieve top 2 records with age less than 60");
            foreach (Person p in PeopleList.FindAll(e => (e.age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: " + p.name + " Age: " + p.age + "\n");
            }

            Console.WriteLine("Retrieve all record with age between 13 & 18 \n");
            foreach (Person p in PeopleList.FindAll(e => (e.age >= 13 && e.age <= 18)).ToList())
            {
                Console.WriteLine("Name: " + p.name);
            }

            Console.WriteLine("Retrieve average age in the list\n");
            double Average = PeopleList.Average(e => e.age);
            Console.WriteLine("Average Age is: " + Average);

        }
    }
}