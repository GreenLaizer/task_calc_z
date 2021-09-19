using System;
using System.Threading;
using task_calc_z;

namespace ConsoleApp218
{
    public interface ISum
    {
        double Sum();
    }

    public interface ILogger
    {
        void Error(string message);
        void Event(string message);
    }


    class Program
    {
        static ILogger Logger { get; set; }
        static double Algorithm(ISum t)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите 1 число");
                    double firstvalue = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите 2 число");
                    double secondvalue = double.Parse(Console.ReadLine());
                    double res = firstvalue + secondvalue;
                    Console.WriteLine("Ваш результат ");
                    return res;
                }
                catch (Exception)
                {
                    Console.WriteLine("Необходимо вводить цифры");
                    Console.ReadLine();
                    continue;
                }
            }

        }

        static void Main(string[] args)
        {

            Sum sum = new Sum();

            double result = Algorithm(sum);

            Console.WriteLine(result);
            Logger = new Logger();
            var worker = new Sum(Logger);

            worker.Work();
            Console.Read();

        }
    }
}
