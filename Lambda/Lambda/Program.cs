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
        }
    }
}