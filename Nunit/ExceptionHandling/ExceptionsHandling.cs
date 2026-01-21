using System;
namespace ExceptionHandling.check
{
    public class DivisionByZero
    {
        public int Divide(int a,int b)
        {
            if (b == 0)
            {
                throw new NullReferenceException("Cant divide it by zero");
            }
            return a/b;
        }
    }
}