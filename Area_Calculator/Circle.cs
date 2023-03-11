namespace Area_Calculator
{
    public class Circle : IFigure
    {
        public double CalculateArea(params double[] args)
        {
            if (args.Length != 1) throw new RankException("Not a circle.");
            if (args[0] <= 0) throw new ArgumentException("Circle can't have given radius.");
            return args[0] * args[0] * Math.PI;
        }
    }
}