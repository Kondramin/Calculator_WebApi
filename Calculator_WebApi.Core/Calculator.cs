namespace Calculator_WebApi.Core
{
    public class Calculator
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Operand { get; set; }


        public int Sum()
        {
            return X + Y;
        }

        public int Difference()
        {
            return X - Y;
        }

        public int Multipli()
        {
            return X * Y;
        }

        public int Division()
        {
            return X / Y;
        }

    }
}
