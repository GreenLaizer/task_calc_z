using ConsoleApp218;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace task_calc_z
{
    public class Sum : ISum, ILogger
    {
        ILogger Logger { get; }
        public Sum(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Начал работу");
            Thread.Sleep(3000);
            Logger.Error("Произошла ошибка");
        }

        public double firstvalue { get; set; }

        public double secondvalue { get; set; }


        public Sum()
        {

        }

        double ISum.Sum()
        {
            return firstvalue + secondvalue;
        }

        public void Error(string message)
        {
            Logger.Error(message);
        }

        public void Event(string message)
        {
            Logger.Event(message);
        }
    }
}
