
namespace CalculatorLibrary.Calc
{
    public class ProgrammerCalculator : ClassicCalculator
    {
        public ProgrammerCalculator()
        {
            LastResult = "0";
        }

        public int And(int a, int b)
        {
            var r = a & b;
            SetLast(r);
            return r;
        }

        public int Or(int a, int b)
        {
            var r = a | b;
            SetLast(r);
            return r;
        }

        public int Xor(int a, int b)
        {
            var r = a ^ b;
            SetLast(r);
            return r;
        }

        public string ToBinary(int value)
        {
            var r = Convert.ToString(value, 2);
            SetLast(r);
            return r;
        }

        public string ToHex(int value)
        {
            var r = Convert.ToString(value, 16).ToUpperInvariant();
            SetLast(r);
            return r;
        }

        public override double Divide(double a, double b)
        {
            if (a > double.MaxValue || b > double.MaxValue)
            {
                throw new OverflowException($"Вводимое число не может привышать максимально допустимое значение double: {double.MaxValue}");
            }

            return base.Divide(a, b);
        }
    }
}
