namespace Area_Calculator
{
    public class Unknown : IFigure
    {
        public double CalculateArea(params double[] args)
        {
            Console.Write("What figure it should be? ");
            IFigure figure = Console.ReadLine().ToLower() switch
            {
                "circle" => new Circle(),
                "triangle" => new Triangle(),
                _ => throw new RankException("Can't calculate this figure"),
            };
            return figure?.CalculateArea(args) ?? 0;
        }
    }
}