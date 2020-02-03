using System;
namespace FactoryPatternExercise
{
    public class Motorola : ICallable
    {
        public void Build()
        {
            Console.WriteLine("You have built a Motorola");
        }
    }
}
