namespace Name_output
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string symbol;
            int lengthName;
            int lengthString;
            int positionCursorX = 1;
            int positionCursorY = 1;
            int quantityStrings = 3;
            int quantityAdditionalCharacters = 2;

            name = Console.ReadLine();
            symbol = Console.ReadLine();
            lengthName = name.Length;
            lengthString = lengthName + quantityAdditionalCharacters;
            Console.Clear();

            for (int i = 0; i < quantityStrings; i++)
            {
                for (int y = 0; y < lengthString; y++)
                {
                    Console.Write(symbol);
                }

                Console.Write("\n");
            }

            Console.SetCursorPosition(positionCursorX, positionCursorY);
            Console.Write(name);
            Console.Write("\n");
            Console.Write("\n");
        }
    }
}