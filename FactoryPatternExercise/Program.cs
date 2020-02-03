using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of phone would you like?");
            string phoneType = Console.ReadLine();

            ICallable phone = PhoneFactory.GetPhone(phoneType);
            phone.Build();

        }
    }
}
