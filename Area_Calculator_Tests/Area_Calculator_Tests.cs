namespace Area_Calculator
{
    public class Tests
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(0.3)]
        [TestCase(4.7)]
        public void CircleTest(double arg)
        {
            Assert.AreEqual(Math.PI*arg*arg, new Circle().CalculateArea(arg));
        }
        [Test]
        public static void CircleRandomTest()
        {
            Random r = new Random();
            for (int i = 0; i < 50; i++)
            {
                double num = r.NextDouble() + r.Next(0, 10) + 0.00001;
                Assert.AreEqual(Math.Round(Math.PI * num * num, 5), Math.Round(new Circle().CalculateArea(num), 5));
            }
        }
        [Test]
        public void TriangleTest()
        {
            Assert.AreEqual(9.92157, Math.Round(new Triangle().CalculateArea(4, 5, 6), 5));
            Assert.AreEqual(2.90474, Math.Round(new Triangle().CalculateArea(2, 3, 4), 5));
        }
    }
}