using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExercise
{
    public class Baby
    {
        private string Name { get; set; }
        private string LastName { get; set; }
        private DateTime DateOfBirth { get; set; }

        public Baby()
        {
            Console.WriteLine("Ingaaaa!");
            DateTime DateOfBirth = DateTime.Now;
        }

        public Baby(string name, string lastName)
        {
            Console.WriteLine("Ingaaaa!");
            Name = name;
            LastName = lastName;
            DateTime DateOfBirth = DateTime.Now;
        }
        
        public void Greet()
        {
            Console.WriteLine($"Baby: ");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"LastName: {LastName}");
            Console.WriteLine($"Date of Birth: {DateOfBirth}");
        }

    }
}
