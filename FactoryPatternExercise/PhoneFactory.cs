using System;
namespace FactoryPatternExercise
{
    public static class PhoneFactory
    {
        public static ICallable GetPhone(string phoneType)
        {
            switch(phoneType.ToLower())
            {
                case "nokia":
                    return new Nokia();
                case "motorola":
                case "razor":
                    return new Motorola();
                case "apple":
                case "iphone":
                    return new Apple();
                default:
                    return new Apple();

            }
        }
    }
}
