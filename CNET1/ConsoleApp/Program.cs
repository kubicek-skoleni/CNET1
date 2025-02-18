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


// 1. kolik obsahuje pole kladných čísel
// 2. kolik obsahuje pole záporných čísel
// 3. sumu kladných hodnot
// 4. najděte první tři největší absolutní hodnoty
// 5. seřaďte pole od nejmenších po největší hodnoty, 
//    přeskočte první 3 prvky a sečtěte zbytek hodnot


var result_1 = numbers.Where(x => x > 0).Count();
Console.WriteLine($"1: {result_1}");

var result_2 = numbers.Where(x => x < 0).Count();
Console.WriteLine($"2: {result_2}");

var result_3 = numbers.Where(x => x > 0).Sum();
Console.WriteLine($"3: {result_3}");

var result_4 = numbers.Select(x => Math.Abs(x))
                      .OrderByDescending(x => x)
                      .Take(3);
Console.WriteLine("4: " + string.Join(", ", result_4));

var result_5 = numbers.OrderBy(x => x).Skip(3).Sum();
Console.WriteLine($"5: {result_5}");










//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}

//Console.WriteLine(string.Join(", ", numbers));













