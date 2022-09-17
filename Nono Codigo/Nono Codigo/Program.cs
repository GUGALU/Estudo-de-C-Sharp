namespace Nono_COdigo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var x = 10;
            //var y = 20.0;
            //var z = "Maria";

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Sunday/Domindo";
                    break;
                case 2:
                    day = "Monday/Segunda";
                    break;
                case 3:
                    day = "Tuesday/Terça";
                    break;
                case 4:
                    day = "Wednesday/Quarta";
                    break;
                case 5:
                    day = "Thursday/Quinta";
                    break;
                case 6:
                    day = "Friday/Sexta";
                    break;
                case 7:
                    day = "Saturday/Sabado";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }
            Console.WriteLine("Day: " + day);
        }
    }
}
