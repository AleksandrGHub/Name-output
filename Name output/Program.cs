namespace Name_output
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string symbol;
            string firstLine = "";
            string secondLine;

            name = Console.ReadLine();
            symbol = Console.ReadLine();

            secondLine = symbol + name + symbol;

            Console.Clear();

            for (int i = 0; i < secondLine.Length; i++)
            {
                firstLine += symbol;
            }

            Console.WriteLine(firstLine);
            Console.WriteLine(secondLine);
            Console.WriteLine(firstLine);
        }
    }
}