namespace OpenClosed.App
{
    public class Sum : Operation
    {

        private readonly Number Number;
        private Sum(Number number)
        {
            Number = number;
        }

        public static Sum Create(Number number)
        {
            return new Sum(number);
        }
       
        public override int Calculate()
        {
            return this.Number.Number1 + Number.Number2;
        }
    }
}
