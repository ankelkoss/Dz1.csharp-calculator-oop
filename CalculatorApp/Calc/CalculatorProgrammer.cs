
using CalculatorLibrary;
using CalculatorLibrary.Calc;
using CalculatorLibrary.Enum;

namespace CalculatorApp.Calc
{
    public static class CalculatorProgrammer
    {
        static CalcPrgrmrEnum calcPrgrmrEnum = CalcPrgrmrEnum.None;
        static ProgrammerCalculator programmerCalculator = new ProgrammerCalculator();

        static string Symbol
        {
            get
            {
                switch (calcPrgrmrEnum)
                {
                    case CalcPrgrmrEnum.None:
                        return "";

                    case CalcPrgrmrEnum.And:
                        return "And";

                    case CalcPrgrmrEnum.Or:
                        return "Or";

                    case CalcPrgrmrEnum.Xor:
                        return "Xor";

                    case CalcPrgrmrEnum.ToBinary:
                        return "ToBinary";

                    case CalcPrgrmrEnum.ToHex:
                        return "ToHex";

                    case CalcPrgrmrEnum.Add:
                        return "Add";

                    case CalcPrgrmrEnum.Subtract:
                        return "Subtract";

                    case CalcPrgrmrEnum.Multiply:
                        return "Multiply";

                    case CalcPrgrmrEnum.Divide:
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

                    if (calcPrgrmrEnum == CalcPrgrmrEnum.None)
                    {
                        MsgFirst();
                    }

                    if (key == "an" && calcPrgrmrEnum == CalcPrgrmrEnum.None)
                    {
                        calcPrgrmrEnum = CalcPrgrmrEnum.And;
                        MsgBack();
                    }

                    if (key == "or" && calcPrgrmrEnum == CalcPrgrmrEnum.None)
                    {
                        calcPrgrmrEnum = CalcPrgrmrEnum.Or;
                        MsgBack();
                    }

                    if (key == "xr" && calcPrgrmrEnum == CalcPrgrmrEnum.None)
                    {
                        calcPrgrmrEnum = CalcPrgrmrEnum.Xor;
                        MsgBack();
                    }

                    if (key == "tb" && calcPrgrmrEnum == CalcPrgrmrEnum.None)
                    {
                        calcPrgrmrEnum = CalcPrgrmrEnum.ToBinary;
                        MsgBack();
                    }

                    if (key == "th" && calcPrgrmrEnum == CalcPrgrmrEnum.None)
                    {
                        calcPrgrmrEnum = CalcPrgrmrEnum.ToHex;
                        MsgBack();
                    }

                    if (key == "ad" && calcPrgrmrEnum == CalcPrgrmrEnum.None)
                    {
                        calcPrgrmrEnum = CalcPrgrmrEnum.Add;
                        MsgBack();
                    }

                    if (key == "st" && calcPrgrmrEnum == CalcPrgrmrEnum.None)
                    {
                        calcPrgrmrEnum = CalcPrgrmrEnum.Subtract;
                        MsgBack();
                    }

                    if (key == "mp" && calcPrgrmrEnum == CalcPrgrmrEnum.None)
                    {
                        calcPrgrmrEnum = CalcPrgrmrEnum.Multiply;
                        MsgBack();
                    }

                    if (key == "dv" && calcPrgrmrEnum == CalcPrgrmrEnum.None)
                    {
                        calcPrgrmrEnum = CalcPrgrmrEnum.Divide;
                        MsgBack();
                    }

                    //

                    if (calcPrgrmrEnum == CalcPrgrmrEnum.And)
                    {
                        var (first, second, isNeedExit) = KeyHendler();

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} {2} = {3}", first, Symbol, second, programmerCalculator.And(first, second)));
                            MsgAfter();
                        }
                    }

                    if (calcPrgrmrEnum == CalcPrgrmrEnum.Or)
                    {
                        var (first, second, isNeedExit) = KeyHendler();

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} {2} = {3}", first, Symbol, second, programmerCalculator.Or(first, second)));
                            MsgAfter();
                        }
                    }

                    if (calcPrgrmrEnum == CalcPrgrmrEnum.Xor)
                    {
                        var (first, second, isNeedExit) = KeyHendler();

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} {2} = {3}", first, Symbol, second, programmerCalculator.Xor(first, second)));
                            MsgAfter();
                        }
                    }

                    if (calcPrgrmrEnum == CalcPrgrmrEnum.ToBinary)
                    {
                        // only one variable
                        var (first, second, isNeedExit) = KeyHendler(true);

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} = {2}", first, Symbol, programmerCalculator.ToBinary(first)));
                            MsgAfter();
                        }
                    }

                    if (calcPrgrmrEnum == CalcPrgrmrEnum.ToHex)
                    {
                        // only one variable
                        var (first, second, isNeedExit) = KeyHendler(true);

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} = {2}", first, Symbol, programmerCalculator.ToHex(first)));
                            MsgAfter();
                        }
                    }

                    if (calcPrgrmrEnum == CalcPrgrmrEnum.Add)
                    {
                        var (first, second, isNeedExit) = KeyHendler();

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} {2} = {3}", first, Symbol, second, programmerCalculator.Add(first, second)));
                            MsgAfter();
                        }
                    }

                    if (calcPrgrmrEnum == CalcPrgrmrEnum.Subtract)
                    {
                        var (first, second, isNeedExit) = KeyHendler();

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} {2} = {3}", first, Symbol, second, programmerCalculator.Subtract(first, second)));
                            MsgAfter();
                        }
                    }

                    if (calcPrgrmrEnum == CalcPrgrmrEnum.Multiply)
                    {
                        var (first, second, isNeedExit) = KeyHendler();

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} {2} = {3}", first, Symbol, second, programmerCalculator.Multiply(first, second)));
                            MsgAfter();
                        }
                    }

                    if (calcPrgrmrEnum == CalcPrgrmrEnum.Divide)
                    {
                        var (first, second, isNeedExit) = KeyHendler();

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} {2} = {3}", first, Symbol, second, programmerCalculator.Divide(first, second)));
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

        static (int, int, bool) KeyHendler(bool single = false)
        {
            bool isNeedExit = false;
            int first = 0, second = 0;

            ConsoleWorker.ClearLine(2);
            ConsoleWorker.UpdateLine(2, $"Последний результат: {programmerCalculator.LastResult}");
            ConsoleWorker.UpdateLine(3, "Введите ПЕРВОЕ число, нажмите и ввод");

            while (isNeedExit == false)
            {
                Console.SetCursorPosition(1, 6);

                var (isDoneFirst, isExit, f_temp) = ConsoleHandler.Int(Console.ReadLine()!);

                if (isExit)
                {
                    isNeedExit = isExit;
                    calcPrgrmrEnum = CalcPrgrmrEnum.None;
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

                    var (isDoneSecond, isExit, f_temp) = ConsoleHandler.Int(Console.ReadLine()!);

                    if (isExit)
                    {
                        isNeedExit = isExit;
                        calcPrgrmrEnum = CalcPrgrmrEnum.None;
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
   And = an
   Or = or
   Xor = xr
   ToBinary = tb
   ToHex = th
   Add = ad 
   Subtract = st 
   Multiply = mp
   Divide = dv");
            Console.SetCursorPosition(2, 14);
        }
        static void MsgBack() => ConsoleWorker.UpdateLine(0, $"Вы выбрали метод {Symbol}. Введите g и нажмите ввод для возврата к меню выбора методов калькулятора");
        static void MsgAfter() => ConsoleWorker.UpdateLine(4, "Для продолжения нажмите любую кнопку...");
    }
}
