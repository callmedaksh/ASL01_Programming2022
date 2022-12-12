namespace ObjectOrientedProgrammingContinuation
{
    public class DummyLinesProvider : ILinesProvider
    {
        public string[] GetLines()
        {
            return new[]
            {
                "Bread;Food;100;2020-01-01",
                "Dress;Clothing;100;2020-01-01",
                "Bread;Food;100;2020-01-01",
                "Bread;Food;100;2020-01-01",
            };
        }
    }
}
