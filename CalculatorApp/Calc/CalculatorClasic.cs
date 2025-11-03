
using CalculatorLibrary;
using CalculatorLibrary.Calc;
using CalculatorLibrary.Enum;

namespace CalculatorApp.Calc
{
    public static class CalculatorClasic
    {
        static CalcClssicEnum calcClssicEnum = CalcClssicEnum.None;
        static ClassicCalculator classicCalculator = new ClassicCalculator();

        static string Symbol
        {
            get
            {
                switch (calcClssicEnum)
                {
                    case CalcClssicEnum.None:
                        return "";

                    case CalcClssicEnum.Add:
                        return "Add";

                    case CalcClssicEnum.Subtract:
                        return "Subtract";

                    case CalcClssicEnum.Multiply:
                        return "Multiply";

                    case CalcClssicEnum.Divide:
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

                    if (calcClssicEnum == CalcClssicEnum.None)
                    {
                        MsgFirst();
                    }

                    if (key == "ad" && calcClssicEnum == CalcClssicEnum.None)
                    {
                        calcClssicEnum = CalcClssicEnum.Add;
                        MsgBack();
                    }

                    if (key == "st" && calcClssicEnum == CalcClssicEnum.None)
                    {
                        calcClssicEnum = CalcClssicEnum.Subtract;
                        MsgBack();
                    }

                    if (key == "mp" && calcClssicEnum == CalcClssicEnum.None)
                    {
                        calcClssicEnum = CalcClssicEnum.Multiply;
                        MsgBack();
                    }

                    if (key == "dv" && calcClssicEnum == CalcClssicEnum.None)
                    {
                        calcClssicEnum = CalcClssicEnum.Divide;
                        MsgBack();
                    }

                    //

                    if (calcClssicEnum == CalcClssicEnum.Add)
                    {
                        var (first, second, isNeedExit) = KeyHendler();

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} {2} = {3}", first, Symbol, second, classicCalculator.Add(first, second)));
                            MsgAfter();
                        }
                    }

                    if (calcClssicEnum == CalcClssicEnum.Subtract)
                    {
                        var (first, second, isNeedExit) = KeyHendler();

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} {2} = {3}", first, Symbol, second, classicCalculator.Subtract(first, second)));
                            MsgAfter();
                        }
                    }

                    if (calcClssicEnum == CalcClssicEnum.Multiply)
                    {
                        var (first, second, isNeedExit) = KeyHendler();

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} {2} = {3}", first, Symbol, second, classicCalculator.Multiply(first, second)));
                            MsgAfter();
                        }
                    }

                    if (calcClssicEnum == CalcClssicEnum.Divide)
                    {
                        var (first, second, isNeedExit) = KeyHendler();

                        if (isNeedExit == false)
                        {
                            ConsoleWorker.ClearLine(3);
                            ConsoleWorker.UpdateLine(3, string.Format("{0} {1} {2} = {3}", first, Symbol, second, classicCalculator.Divide(first, second)));
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

        static (double, double, bool) KeyHendler()
        {
            bool isNeedExit = false;
            double first = 0.0, second = 0.0;

            ConsoleWorker.ClearLine(2);
            ConsoleWorker.UpdateLine(2, $"Последний результат: {classicCalculator.LastResult}");
            ConsoleWorker.UpdateLine(3, "Введите ПЕРВОЕ число, нажмите и ввод");

            while (isNeedExit == false)
            {
                Console.SetCursorPosition(1, 6);

                var (isDoneFirst, isExit, f_temp) = ConsoleHandler.Double(Console.ReadLine()!);

                if (isExit)
                {
                    isNeedExit = isExit;
                    calcClssicEnum = CalcClssicEnum.None;
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
                    calcClssicEnum = CalcClssicEnum.None;
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

            return (first, second, isNeedExit);
        }
        static void MsgFirst()
        {
            ConsoleWorker.ClearLine(0);
            ConsoleWorker.UpdateLine(0, "Вернуться к выбору типа калькулятора - введите b и нажмите ввод");
            ConsoleWorker.UpdateLine(1, @"Выберите доступные методы калькулятора, для выбора введите комбинацию и нажмите ввод
   Add = ad 
   Subtract = st 
   Multiply = mp
   Divide = dv");
            Console.SetCursorPosition(2, 7);
        }
        static void MsgBack() => ConsoleWorker.UpdateLine(0, $"Вы выбрали метод {Symbol}. Введите g и нажмите ввод для возврата к меню выбора методов калькулятора");
        static void MsgAfter() => ConsoleWorker.UpdateLine(4, "Для продолжения нажмите любую кнопку...");
    }
}
