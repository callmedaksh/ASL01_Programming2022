using System.IO;

namespace ObjectOrientedProgrammingContinuation
{
    public class FileLinesProvider : ILinesProvider
    {
        public string[] GetLines()
        {
            return File.ReadAllLines(@"C:\Users\Marcin\Desktop\Invoices.txt");
        }
    }
}
