
namespace CalculatorLibrary.Calc
{
    public class ClassicCalculator
    {
        public string LastResult { get; protected set; }

        public ClassicCalculator()
        {
            LastResult = "0";
        }

        public double Add(double a, double b)
        {
            var r = a + b;
            SetLast(r);
            return r;
        }

        public double Subtract(double a, double b)
        {
            var r = a - b;
            SetLast(r);
            return r;
        }

        public double Multiply(double a, double b)
        {
            var r = a * b;
            SetLast(r);
            return r;
        }

        public virtual double Divide(double a, double b)
        {
            if (b == 0.0)
            {
                throw new DivideByZeroException("Деление на ноль.");
            }

            var r = a / b;
            SetLast(r);
            return r;
        }

        protected void SetLast(object item)
        {
            LastResult = item.ToString() ?? "0";
        }
    }
}
