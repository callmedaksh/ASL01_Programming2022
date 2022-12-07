using System.Linq;

var heights = new int[] { 156, 178, 192, 181, 176, 158, 178, 191, 181, 192, 172, 178 };
var names = new string[] {"James Bond", "Jason Bourne", "Ann Shirley", "Jeff Bezos", "Ronaldo", "Jose Maria Marias"};
//var maxHeight = heights[0];

//for (var i = 1; i < heights.Length; i++)
//{
//    if (heights[i] > maxHeight)
//    {
//        maxHeight = heights[i];
//    }
//}

//Console.WriteLine(maxHeight);

//Console.WriteLine(heights.Max());
//Console.WriteLine(heights.Min());
//Console.WriteLine(heights.Count());
//Console.WriteLine(heights.Sum());
//Console.WriteLine(heights.Average());

//filtering -> Where  !!

var highOnes = heights.Where(x => x >= 178);
var oddHeights = heights.Where(x => x % 2 == 1);
var withSixAtTheEnd  = heights.Where(x => x % 10 == 6);

var withTwoNames = names.Where(x => x.Split(" ").Length == 2);
var startingWithJ = names.Where(x => x.StartsWith("J"));

//ordering -> OrderBy !!

var ascendingHeights = heights.OrderBy(x => x);
var ascendingNames = names.OrderBy(x => x);
var ascendingNamesByLength = names.OrderBy(x => x.Length);

var descendingNamesByLength = names.OrderByDescending(x => x.Length);

//projection -> Select  !!!

var upperCased = names.Select(x => x.ToUpper());
var highOrLow = heights.Select(x => x >= 178);
var initials = names.Select(x => string.Join("", x.Split(" ").Select(y => y[0])));

//combine things:

Display(heights.Where(x => x >= 178).OrderByDescending(x => x).Select(x => x / 100.0).Distinct());



void Display<T>(IEnumerable<T> collection) => collection.ToList().ForEach(x => Console.WriteLine(x));
