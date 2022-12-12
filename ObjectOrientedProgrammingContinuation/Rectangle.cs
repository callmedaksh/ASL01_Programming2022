namespace ObjectOrientedProgrammingContinuation
{
    public class Rectangle : Shape
    {
        private double _a;
        private double _b;

        public Rectangle(double a, double b) => (_a, _b) = (a, b);

        public override double Area() => _a * _b;

        public override double Perimeter() => 2 * (_a + _b);
    }
}
