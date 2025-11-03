
namespace CalculatorLibrary
{
    public static class ConsoleHandler
    {
        public static (bool, bool, double) Double(string d)
        {
            bool isDone = false;
            bool isExit = false;
            double res = 0.0;

            try
            {
                if (d.ToLower() == "g")
                {
                    isExit = true;
                    isDone = false;
                }
                else
                {
                    res = double.Parse(d.Replace(".", ","));
                    isDone = true;
                }
            }
            catch
            {
                // doesn't matter
                // isDone = false
                // something error
            }

            return (isDone, isExit, res);
        }

        public static (bool, bool, int) Int(string d)
        {
            bool isDone = false;
            bool isExit = false;
            int res = 0;

            try
            {
                if (d.ToLower() == "g")
                {
                    isExit = true;
                    isDone = false;
                }
                else
                {
                    res = int.Parse(d);
                    isDone = true;
                }
            }
            catch
            {
                // doesn't matter
                // isDone = false
                // something error
            }

            return (isDone, isExit, res);
        }
    }
}
