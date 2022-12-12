using System;

namespace ObjectOrientedProgrammingContinuation
{
    public class A
    {
        protected void APrivateMethod()
        {
            Console.WriteLine("Private method called");
        }

        public void MyMethod()
        {
            APrivateMethod();
            Console.WriteLine("A method called");
        }
    }


}
