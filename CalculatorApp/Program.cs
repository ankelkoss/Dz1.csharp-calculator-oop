using CalculatorApp.Calc;
using CalculatorLibrary;
using CalculatorLibrary.Enum;
using System.Text;

namespace CalculatorApp
{
    static class Program
    {
        static CalculatorTypeEnum calculatorType = CalculatorTypeEnum.None;

        static void Main()
        {
            Console.OutputEncoding = new UTF8Encoding(false);
            Console.InputEncoding = new UTF8Encoding(false);

            MsgFirst();

            Task.Run(() => OnKeypress()).Wait();
        }

        static void OnKeypress()
        {
            while (true)
            {
                try
                {
                    var key = Console.ReadKey(true).KeyChar.ToString().ToLowerInvariant();

                    if (key == "q")
                        break;

                    if (key == "c" && calculatorType == CalculatorTypeEnum.None)
                        calculatorType = CalculatorTypeEnum.ClassicCalc;

                    if (key == "p" && calculatorType == CalculatorTypeEnum.None)
                        calculatorType = CalculatorTypeEnum.ProgrammerCalc;

                    if (key == "s" && calculatorType == CalculatorTypeEnum.None)
                        calculatorType = CalculatorTypeEnum.ScientificCalc;

                    if (calculatorType == CalculatorTypeEnum.ClassicCalc)
                    {
                        ConsoleWorker.ClearLine(2);
                        ConsoleWorker.UpdateLine(2, "Вернуться к выбору типа калькулятора нажмите b ");
                        ConsoleWorker.UpdateLine(3, "Вы выбрали: Classic Calculator ");

                        Task.Run(() => CalculatorClasic.OnKeypress()).Wait();

                        // after exit Task
                        calculatorType = CalculatorTypeEnum.None;
                        MsgFirst();
                    }

                    if (calculatorType == CalculatorTypeEnum.ProgrammerCalc)
                    {
                        ConsoleWorker.ClearLine(2);
                        ConsoleWorker.UpdateLine(2, "Вернуться к выбору типа калькулятора нажмите b ");
                        ConsoleWorker.UpdateLine(3, "Вы выбрали: Programmer Calculator");

                        Task.Run(() => CalculatorProgrammer.OnKeypress()).Wait();

                        // after exit Task
                        calculatorType = CalculatorTypeEnum.None;
                        MsgFirst();
                    }

                    if (calculatorType == CalculatorTypeEnum.ScientificCalc)
                    {
                        ConsoleWorker.ClearLine(2);
                        ConsoleWorker.UpdateLine(2, "Вернуться к выбору типа калькулятора нажмите b ");
                        ConsoleWorker.UpdateLine(3, "Вы выбрали: Scientific Calculator");

                        Task.Run(() => CalculatorScientific.OnKeypress()).Wait();

                        // after exit Task
                        calculatorType = CalculatorTypeEnum.None;
                        MsgFirst();
                    }
                }
                catch (Exception e)
                {
                    ConsoleWorker.ClearLine(0);
                    ConsoleWorker.UpdateLine(1, $"Error: {e} \r\n\r\n\r\n Для продолжения нажмите любую клавишу");
                    Console.ReadLine();
                }
            }

            ConsoleWorker.ClearLine(1, 2);
            ConsoleWorker.UpdateLine(0, "Калькулятор завершил работу");
        }

        static void MsgFirst()
        {
            ConsoleWorker.ClearLine(0);
            ConsoleWorker.UpdateLine(0, "Калькулятор запущен, для ввыхода нажмите q");
            ConsoleWorker.UpdateLine(1, "Доступно 3 вида калькулятора, для выбора нажмите соответствующую букву: \r\n\r\n Classic Calculator = c \r\n Programmer Calculator = p \r\n Scientific Calculator s");
            Console.SetCursorPosition(2, 7);
        }
    }
}