namespace Oitavo_Codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[,] matriz = new double[2, 3];

            //Console.WriteLine(matriz.Length);

            //Console.WriteLine(matriz.Rank);

            //Console.WriteLine(matriz.GetLength(0));

            //Console.WriteLine(matriz.GetLength(1));

            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for(int i = 0; i< n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for(int j =0; j< n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Total negative numbers: " + count);
        }
    }
}