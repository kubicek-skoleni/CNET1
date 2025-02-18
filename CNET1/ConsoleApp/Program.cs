//LINQ

int[] numbers = [33, -234, 0, 1223, 43223, -999999, 0, 11, 23];

// where - filtr
var kladna = numbers.Where(number => number >= 0);

// orderBy - řazení
var ordered = numbers.OrderByDescending(number => number);

// Take
var first_5 = numbers.Take(5);

// skip
var skip_5 = numbers.Skip(5);

// agregační - Max, Min, Sum, Average
var max = numbers.Max();
var sum = numbers.Sum();    
var avg = numbers.Average();
var count = numbers.Count();

// select - transormační 
var abs = numbers.Select(number => Math.Abs(number));

// First, FirstOrDefault,..
var first = numbers.First();

var smallest_3 = numbers.OrderBy(number => number).Take(3);


Console.WriteLine("numbers: " + string.Join(", ", numbers));
Console.WriteLine("kladna: " + string.Join(", ", kladna));
Console.WriteLine("ordered: " + string.Join(", ", ordered));
Console.WriteLine("first_5: " + string.Join(", ", first_5));
Console.WriteLine("skip_5: " + string.Join(", ", skip_5));
Console.WriteLine($"max: {max}");
Console.WriteLine($"sum: {sum}");
Console.WriteLine($"avg: {avg}");
Console.WriteLine($"count: {count}");
Console.WriteLine("abs: " + string.Join(", ", abs));
Console.WriteLine("smallest_3: " + string.Join(", ", smallest_3));


//  1. kolik obsahuje pole kladných čísel
// 




//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}

//Console.WriteLine(string.Join(", ", numbers));













