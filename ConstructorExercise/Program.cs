using System;

namespace ConstructorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Baby baby1 = new Baby();
            baby1.Greet();
            Baby baby2 = new Baby("Botan", "Elveren");
            baby2.Greet();
        }
    }
}