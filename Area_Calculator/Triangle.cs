namespace Area_Calculator
{
    public class Triangle : IFigure
    {
        public double CalculateArea(params double[] args)
        {
            if (args.Length != 3) throw new RankException("Not a triangle.");
            double a, b, c;
            a = args[0];
            b = args[1];
            c = args[2];
            if (a + b <= c || a + c <= b || b + c <= a || a <= 0 || b <= 0 || c <= 0) throw new ArgumentException("Triangle can't have sides with given lengths.");
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        }
        public bool IsRight(params double[] args)
        {
            Array.Sort(args);
            return Math.Pow(args[0], 2) + Math.Pow(args[1], 2) == Math.Pow(args[2], 2);
        }
    }
}