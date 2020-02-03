using System;
namespace FactoryPatternExercise
{
    public class Nokia : ICallable
    {

        public void Build()
        {
            Console.WriteLine("You have built a Nokia");
        }
    }
}
