
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace FunctionalDesignPatterns.ExecutionAround
{
    internal static class ExecutionWrapper
    {
        public static void WrapWithLogging(Action action)
        {
            Console.WriteLine("\n   Start operation");
            Console.WriteLine("-----------------------");
            var watch = Stopwatch.StartNew();
            try
            {
                action();
                Thread.Sleep(Random.Shared.Next(20,50));
                watch.Stop();
                Console.WriteLine("Sucess, execution time: " + watch.ElapsedMilliseconds + " ms");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.ToString());
            }
            finally
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("  Operation Complete");
            }
        }
    }
}
