using System;

namespace OOP_With_CSharp
{
    public class StopWatch
    {
        private readonly Starter _starter;
        private readonly Stopper _stopper;


        //Constructors
        public StopWatch(Starter starter, Stopper stopper)
        {
            _starter = starter;
            _stopper = stopper;
        }
        public void App()
        {
            while (true)
            {
                var startTime = _starter.Start(new DateTime());
                Console.Write("Enter 'STOP' to stop the watch, or 'QUIT' to exit app: ");
                var input = Console.ReadLine();

                if (input == "QUIT") break;

                if (input != "STOP")
                {
                    Console.WriteLine("'STOP' is the magic word. Time is still running...");
                    input = Console.ReadLine();
                    if (input == "STOP")
                    {
                        var stopTime = _stopper.Stop(new DateTime());
                        var timeSpan = startTime - stopTime;
                        System.Console.WriteLine(timeSpan);
                    }
                }
                else
                {
                    var stopTime = _stopper.Stop(new DateTime());
                    var timeSpan = startTime - stopTime;
                    System.Console.WriteLine(timeSpan);
                }
            }
        }
    }
}