
namespace System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 10, 12, 15, 10, 23);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Hello BRAH";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
