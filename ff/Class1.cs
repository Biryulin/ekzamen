using System;
using System.Collections.Generic;

namespace ff
{
    public class Hobby
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public void Show()
        {
            Console.WriteLine($"Hobby: {Name}, Description: {Description}");
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Hobby> Hobbies { get; set; } = new List<Hobby>();

        public void ShowAll()
        {
            Console.WriteLine($"Person: {Name}, Address: {Address}");
            foreach (var hobby in Hobbies)
            {
                hobby.Show();
            }
        }
    }
}
