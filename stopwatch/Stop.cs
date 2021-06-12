using System;

namespace OOP_With_CSharp
{
    public class Stopper
    {
        public DateTime Stop(DateTime stop)
        {
            stop = DateTime.Now;
            return stop;
        }
    }
}