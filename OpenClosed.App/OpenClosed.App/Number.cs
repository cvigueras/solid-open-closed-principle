namespace OpenClosed.App
{
    public class Number
    {
        public readonly int Number1;
        public readonly int Number2;
        private Number(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public static Number Create(int number1, int number2)
        {
            return new Number(number1, number2);
        }
    }
}
