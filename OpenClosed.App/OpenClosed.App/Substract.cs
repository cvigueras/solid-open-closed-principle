namespace OpenClosed.App
{
    public class Substract : Operation
    {

        private readonly Number Number;
        private Substract(Number number)
        {
            Number = number;
        }

        public static Substract Create(Number number)
        {
            return new Substract(number);
        }

        public override int Calculate()
        {
            return this.Number.Number1 - Number.Number2;
        }
    }
}
