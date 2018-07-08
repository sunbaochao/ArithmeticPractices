using System;
using System.Diagnostics;
using Arithmetics.排序;
using Arithmetics.面试金题;

namespace Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Stopwatch watch = new Stopwatch();
            watch.Start();
            
            AbstractArithmetic arithmetic = new _3_CheckSameString();
            Console.WriteLine($"The Arithmetic Title : {arithmetic.Title}");
            Console.WriteLine($"The Arithmetic Content : {arithmetic.Content}");
            Console.WriteLine($"The result is {arithmetic.GetResult()}");
            
            //经典排序算法
            //var sort = new Sort();
            //sort.MainSort();
            //watch.Stop();
            Console.WriteLine($"Take time: {watch.ElapsedTicks}");
            Console.ReadKey(true);
        }
    }
}
