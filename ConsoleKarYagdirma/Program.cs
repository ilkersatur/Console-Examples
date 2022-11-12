void KarYağdır()
{
    Console.BackgroundColor = ConsoleColor.Gray;
    Console.ForegroundColor = ConsoleColor.Black;
    while (true)
    {
        Console.Clear();
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 100000000; j++) ;
            Random rand = new Random();
            Random rand1 = new Random();
            Console.SetCursorPosition(rand.Next(1, 70), rand1.Next(1, 20));
            Console.WriteLine("*");
        }
    }
}
KarYağdır();