namespace OpenClosed.App
{
    public class Calculator
    {
        public int Calculate(Operation number)
        {
            return number.Number1 + number.Number2;
        }
    }
}
