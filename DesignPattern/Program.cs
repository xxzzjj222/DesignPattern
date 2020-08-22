using DesignPattern.Strategy;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new OperationAdd());
            Console.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5));

            Console.ReadLine();
        }
    }
}
