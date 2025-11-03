
namespace CalculatorLibrary
{
    public static class ConsoleWorker
    {
        static bool IsFirstStart = true;

        public static void UpdateLine(int line, string message)
        {
            if (IsFirstStart)
            {
                for (int i = 0; i < 10; i++)
                    Console.WriteLine();

                IsFirstStart = false;
            }

            int startLine = 1;
            int _line = line + 1;

            int left = Console.CursorLeft;
            int top = Console.CursorTop;

            Console.SetCursorPosition(startLine, _line);
            Console.Write(new string(' ', Console.WindowWidth)); // очистить строку
            Console.SetCursorPosition(startLine, _line);
            Console.Write($"[{DateTime.Now:HH:mm:ss}] - {message}");

            Console.SetCursorPosition(left, top); // вернуть курсор назад
        }

        public static void ClearLine(int line, int cursorLine = 0)
        {
            for (int i = line; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            if (cursorLine == 0)
            {
                Console.SetCursorPosition(1, line + 3);
            }
            else
            {
                Console.SetCursorPosition(1, cursorLine);
            }
        }
    }
}
