
namespace CalculatorLibrary.Calc
{
    public class ScientificCalculator : ClassicCalculator
    {
        public ScientificCalculator()
        {
            LastResult = "0";
        }

        public double Pow(double a, double b)
        {
            var r = Math.Pow(a, b);
            SetLast(r);
            return r;
        }

        public double Sqrt(double a)
        {
            var r = Math.Sqrt(a);
            SetLast(r);
            return r;
        }

        public double Sin(double a)
        {
            var r = Math.Sin(a);
            SetLast(r);
            return r;
        }

        public double Cos(double a)
        {
            var r = Math.Cos(a);
            SetLast(r);
            return r;
        }

        public override double Divide(double a, double b)
        {
            if (b == 0.0)
            {
                throw new DivideByZeroException("Деление на ноль.");
            }

            var r = a / b;

            // just example
            Logger.Log("ScientificCalculator.Divide - Логирование переопределенного метода");

            SetLast(r);
            return r;
        }
    }
}
