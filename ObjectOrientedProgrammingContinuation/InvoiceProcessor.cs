using System;
using System.Collections.Generic;

namespace ObjectOrientedProgrammingContinuation
{
    public class InvoiceProcessor
    {
        private readonly ILinesProvider _linesProvider;

        public InvoiceProcessor(ILinesProvider linesProvider) => 
            _linesProvider = linesProvider;

        public Dictionary<string, decimal> GroupByCategory()
        {
            var content = _linesProvider.GetLines();

            var dictionary = new Dictionary<string, decimal>();

            for (var i = 1; i < content.Length; i++)
            {
                var line = content[i];

                var split = line.Split(";");

                var category = split[1];
                var amount = Convert.ToDecimal(split[2].Replace(".", ","));

                if (!dictionary.ContainsKey(category))
                    dictionary[category] = amount;
                else
                    dictionary[category] += amount;
            }

            return dictionary;
        }
    }
}
