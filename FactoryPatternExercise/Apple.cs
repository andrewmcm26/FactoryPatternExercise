using System;
namespace FactoryPatternExercise
{
    public class Apple : ICallable
    {
        public void Build()
        {
            Console.WriteLine("You have built an iPhone");
        }
    }
}
