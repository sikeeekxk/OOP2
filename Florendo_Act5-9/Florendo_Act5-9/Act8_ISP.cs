using System;

namespace Florendo_Act5_9
{
    internal class Act8_ISP
    {
        internal static void Run()
        {
            IPrinter printer = new BasicPrinter();
            printer.Print("Hello, World!");
        }
    }

    public interface IPrinter
    {
        void Print(string content);
    }

    public interface IScanner
    {
        void Scan(string document);
    }

    public class BasicPrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine($"Printing: {content}");
        }
    }

    public class MultiFunctionPrinter : IPrinter, IScanner
    {
        public void Print(string content)
        {
            Console.WriteLine($"Printing: {content}");
        }

        public void Scan(string document)
        {
            Console.WriteLine($"Scanning: {document}");
        }
    }
}
