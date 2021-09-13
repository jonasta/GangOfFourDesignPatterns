using System;

namespace Facade
{
    public class SystemsFacade
    {
        private readonly SubsystemOne _systemOne;
        private readonly SubsystemTwo _systemTwo;
        private readonly SubsystemThree _systemThree;

        public SystemsFacade()
        {
            _systemOne = new SubsystemOne();
            _systemTwo = new SubsystemTwo();
            _systemThree = new SubsystemThree();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethod A()");
            _systemOne.MethodOne();
            _systemTwo.MethodTwo();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethod B()");
            _systemThree.MethodThree();
        }
    }
}