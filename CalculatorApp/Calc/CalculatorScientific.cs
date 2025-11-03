
using CalculatorLibrary;
using CalculatorLibrary.Calc;
using CalculatorLibrary.Enum;

namespace CalculatorApp.Calc
{
    public static class CalculatorScientific
    {
        static CalcScintfcEnum calcScintfcEnum = CalcScintfcEnum.None;
        static ScientificCalculator scientificCalculator = new ScientificCalculator();

        static string Symbol
        {
            get
            {
                switch (calcScintfcEnum)
                {
                    case CalcScintfcEnum.None:
                        return "";

                    case CalcScintfcEnum.Pow:
                        return "Pow";

                    case CalcScintfcEnum.Sqrt:
                        return "Sqrt";

                    case CalcScintfcEnum.Sin:
                        return "Sin";

                    case CalcScintfcEnum.Cos:
                        return "Cos";

                    case CalcScintfcEnum.Add:
                        return "Add";

                    case CalcScintfcEnum.Subtract:
                        return "Subtract";

                    case CalcScintfcEnum.Multiply:
                        return "Multiply";

                    case CalcScintfcEnum.Divide:
                        return "Divide";

                    default:
                        return "";
                }
            }
        }

        public static void OnKeypress()
        {
            MsgFirst();

            while (true)
            {
                try
                {
                    var key = (Console.ReadLine() ?? "").ToLower();

                    if (key == "b")
                        break;

                    if (calcScintfcEnum == CalcScintfcEnum.None)
                    {
                        MsgFirst();
                    }

                    if (key == "pw" && calcScintfcEnum == CalcScintfcEnum.None)
                    {
                        calcScintfcEnum = CalcScintfcEnum.Pow;
                        MsgBack();
                    }

                    if (key == "sq" && calcScintfcEnum == CalcScintfcEnum.None)
                    {
                        calcScintfcEnum = CalcScintfcEnum.Sqrt;
                        MsgBack();
                    }

                    if (key == "sn" && calcScintfcEnum == CalcScintfcEnum.None)
                    {
                        calcScintfcEnum = CalcScintfcEnum.Sin;
                        MsgBack();
                    }

                    if (key == "cs" && calcScintfcEnum == CalcScintfcEnum.None)
                    {
                        calcScintfcEnum = CalcScintfcEnum.Cos;
                        MsgBack();
                    }

                    if (key == "ad" && calcScintfcEnum == CalcScintfcEnum.None)
                    {
                        calcScintfcEnum = CalcScintfcEnum.Add;
                        MsgBack();
                    }

                    if (key == "st" && calcScintfcEnum == CalcScintfcEnum.None)
                    {
                        calcScintfcEnum = CalcScintfcEnum.Subtract;
                        MsgBack();
                    }

                    if (key == "mp" && calcScintfcEnum == CalcScintfcEnum.None)
                    {
                        calcScintfcEnum = CalcScintfcEnum.Multiply;
                        MsgBack();
                    }

                    if (key == "dv" && calcScintfcEnum == CalcScintfcEnum.None)
                    {
                        calcScintfcEnum = CalcScintfcEnum.Divide;
                        MsgBack();
                    }

                    //

                    if (calcScintfcEnum == CalcScintfcEnum.Pow)
                    {
                        var (first, second, isNeedExit) = KeyHendler();

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} {2} = {3}", first, Symbol, second, scientificCalculator.Pow(first, second)));
                            MsgAfter();
                        }
                    }

                    if (calcScintfcEnum == CalcScintfcEnum.Sqrt)
                    {
                        // only one variable
                        var (first, second, isNeedExit) = KeyHendler(true);

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} = {2}", first, Symbol, scientificCalculator.Sqrt(first)));
                            MsgAfter();
                        }
                    }

                    if (calcScintfcEnum == CalcScintfcEnum.Sin)
                    {
                        // only one variable
                        var (first, second, isNeedExit) = KeyHendler(true);

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} = {2}", first, Symbol, scientificCalculator.Sin(first)));
                            MsgAfter();
                        }
                    }

                    if (calcScintfcEnum == CalcScintfcEnum.Cos)
                    {
                        // only one variable
                        var (first, second, isNeedExit) = KeyHendler(true);

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} = {2}", first, Symbol, scientificCalculator.Cos(first)));
                            MsgAfter();
                        }
                    }

                    if (calcScintfcEnum == CalcScintfcEnum.Add)
                    {
                        var (first, second, isNeedExit) = KeyHendler();

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} {2} = {3}", first, Symbol, second, scientificCalculator.Add(first, second)));
                            MsgAfter();
                        }
                    }

                    if (calcScintfcEnum == CalcScintfcEnum.Subtract)
                    {
                        var (first, second, isNeedExit) = KeyHendler();

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} {2} = {3}", first, Symbol, second, scientificCalculator.Subtract(first, second)));
                            MsgAfter();
                        }
                    }

                    if (calcScintfcEnum == CalcScintfcEnum.Multiply)
                    {
                        var (first, second, isNeedExit) = KeyHendler();

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} {2} = {3}", first, Symbol, second, scientificCalculator.Multiply(first, second)));
                            MsgAfter();
                        }
                    }

                    if (calcScintfcEnum == CalcScintfcEnum.Divide)
                    {
                        var (first, second, isNeedExit) = KeyHendler();

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} {2} = {3}", first, Symbol, second, scientificCalculator.Divide(first, second)));
                            MsgAfter();
                        }
                    }
                }
                catch (Exception e)
                {
                    ConsoleWorker.ClearLine(0);
                    ConsoleWorker.UpdateLine(1, $"Error: {e} \r\n\r\n\r\n Для продолжения нажмите любую клавишу");
                    Console.ReadLine();
                }
            }
        }

        static (double, double, bool) KeyHendler(bool single = false)
        {
            bool isNeedExit = false;
            double first = 0, second = 0;

            ConsoleWorker.ClearLine(2);
            ConsoleWorker.UpdateLine(2, $"Последний результат: {scientificCalculator.LastResult}");
            ConsoleWorker.UpdateLine(3, "Введите ПЕРВОЕ число, нажмите и ввод");

            while (isNeedExit == false)
            {
                Console.SetCursorPosition(1, 6);

                var (isDoneFirst, isExit, f_temp) = ConsoleHandler.Double(Console.ReadLine()!);

                if (isExit)
                {
                    isNeedExit = isExit;
                    calcScintfcEnum = CalcScintfcEnum.None;
                    break;
                }
                else if (isDoneFirst)
                {
                    first = f_temp;
                    break;
                }
                else
                {
                    ConsoleWorker.ClearLine(3);
                    ConsoleWorker.UpdateLine(4, "Ошибка, вводимые данные должны быть числом");
                }
            }

            if (single == false)
            {
                if (isNeedExit == false)
                {
                    ConsoleWorker.ClearLine(3);
                    ConsoleWorker.UpdateLine(4, $"{first} {Symbol}");
                    ConsoleWorker.UpdateLine(3, "Введите ВТОРОЕ число и нажмите ввод");
                }
                else
                {
                    ConsoleWorker.UpdateLine(3, "Нажмите ввод еще раз");
                }

                while (isNeedExit == false)
                {
                    Console.SetCursorPosition(1, 6);

                    var (isDoneSecond, isExit, f_temp) = ConsoleHandler.Double(Console.ReadLine()!);

                    if (isExit)
                    {
                        isNeedExit = isExit;
                        calcScintfcEnum = CalcScintfcEnum.None;
                        break;
                    }
                    else if (isDoneSecond)
                    {
                        second = f_temp;
                        break;
                    }
                    else
                    {
                        ConsoleWorker.ClearLine(3);
                        ConsoleWorker.UpdateLine(4, "Ошибка, вводимые данные должны быть числом");
                    }
                }
            }
            else if (isNeedExit == true)
            {
                ConsoleWorker.UpdateLine(3, "Нажмите ввод еще раз");
            }

            return (first, second, isNeedExit);
        }
        static void MsgFirst()
        {
            ConsoleWorker.ClearLine(0);
            ConsoleWorker.UpdateLine(0, "Вернуться к выбору типа калькулятора нажмите два раза b");
            ConsoleWorker.UpdateLine(1, @"Выберите доступные методы калькулятора, для выбора введите комбинацию
   Pow = pw
   Sqrt = sq 
   Sin = sn
   Cos = cs
   Add = ad 
   Subtract = st 
   Multiply = mp
   Divide = dv");
            Console.SetCursorPosition(2, 12);
        }
        static void MsgBack() => ConsoleWorker.UpdateLine(0, $"Вы выбрали метод {Symbol}. Введите g и нажмите ввод для возврата к меню выбора методов калькулятора");
        static void MsgAfter() => ConsoleWorker.UpdateLine(4, "Для продолжения нажмите любую кнопку...");
    }
}
