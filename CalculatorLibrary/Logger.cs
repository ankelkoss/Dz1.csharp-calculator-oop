namespace CalculatorLibrary
{
    public static class Logger
    {
        // example
        public static void Log(string msg)
        {
            var s = string.Format("{0} - {1}{2}", DateTimeOffset.Now.ToString(), msg, Environment.NewLine);
            Console.WriteLine(msg);

            //TODO: add logging to txt or log file
        }
    }
}
