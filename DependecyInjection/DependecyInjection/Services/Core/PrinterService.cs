using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection.Services.Core
{
    internal class PrinterService: IPrinterService
    {
        public void Print(string document)
        {
            Console.Write($"Printing document: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(document);
            Console.ResetColor();
        }
    }
}
