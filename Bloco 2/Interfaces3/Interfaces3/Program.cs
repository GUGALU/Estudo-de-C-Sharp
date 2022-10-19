using Interfaces3.Devices;
using System;

namespace Interfaces3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer() { SerialNumber = 1080 };
            printer.ProcessDoc("My letter");
            printer.Print("My letter");

            Scanner scanner = new Scanner() { SerialNumber = 2003 };
            scanner.ProcessDoc("My Email");
            Console.WriteLine(scanner.Scan());

            ComboDevice comboDevice = new ComboDevice() { SerialNumber = 3000 };
            comboDevice.ProcessDoc("My dissertation");
            comboDevice.Print("My dissertation");
            Console.WriteLine(comboDevice.Scan());
        }
    }
}
