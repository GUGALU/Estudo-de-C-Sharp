using Bank;
using System.Text.Json;
using System.Text.Json.Serialization;

class Program{
    //static async void Main()// do jeito que esta da erro no c# ja que nem void nem int pode receber async
    static async Task Main()
    {
        Console.WriteLine("Executando...");
        var result = await Task.Run (() =>
        {
            Thread.Sleep(5000);
            Console.WriteLine("Acordou...");
            return "Gustavo";
        });
        Console.WriteLine(result);
        Console.WriteLine("Pronto");
        Console.ReadLine();
    }
}

class BranchCustomer
{
    public string Name {get; set;}

    public string Branch {get; set;}
}
static class Extensions
{
    public static void Texto(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }
}

namespace Bank
{
    public class FileLogger : ILogger
    {
        private readonly string filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }
        public void log(string message)
        {
            File.AppendAllText(filePath, $"{message}{Environment.NewLine}");
        }
    }

    public class ConsoleLogger : ILogger
        {
            public void log(string message)
            {
                Console.WriteLine($"LOGGER: {message}");
            }
        }

        public interface ILogger
        {
            void log(string message);
        }

        public class BankAccount{

            public string Name
            {
                get; private set;
            }

            private readonly ILogger logger;

            public decimal Balance 
            { 
                get; private set; 
            }

            public string Branch;

            [JsonConstructor]
            public BankAccount(string name, decimal balance) : this(name, balance, new ConsoleLogger())
            {
            }

            public BankAccount(string name, decimal balance, ILogger logger){

                if(string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Nome invalido.", nameof(name));
                }
                if (balance < 0)
                {
                    throw new Exception("Saldo não poder ser negativo.");
                }
                Name = name;
                Balance = balance;
                this.logger = logger;
                // this.balance = balance;
                // name = _name
                // balance = _balance
            }
            public void Deposit(decimal amount){
                if (amount <= 0)
                {
                    logger.log($"Não e possivel depositar {amount} na conta de {Name}.");
                    return;
                }
                Balance += amount;
            }
        }
}