namespace ObjectOrientedProgrammingContinuation
{
    public class Square : Shape
    {
        private double _side;

        public Square(double side) => _side = side;

        public override double Area() => _side * _side;

        public override double Perimeter() => 4 * _side;
    }
}
