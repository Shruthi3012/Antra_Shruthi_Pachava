// See https://aka.ms/new-console-template for more information

using Assignment4;

Console.WriteLine("Hello, World!");

/*1. Create a console application project named /02UnderstandingTypes/ that outputs the
number of bytes in memory that each of the following number types uses, and the
minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
ulong, float, double, and decimal.*/
Console.WriteLine("sbyte: Size -> " + sizeof(sbyte) + ", min -> " + sbyte.MinValue + ", max -> " + sbyte.MaxValue );
Console.WriteLine("byte: Size -> " + sizeof(byte) + ", min -> " + byte.MinValue + ", max -> " + byte.MaxValue);
Console.WriteLine("short: Size -> " + sizeof(short) + ", min -> " + short.MinValue + ", max -> " + short.MaxValue);
Console.WriteLine("ushort: Size -> " + sizeof(ushort) + ", min -> " + ushort.MinValue + ", max -> " + ushort.MaxValue);
Console.WriteLine("int: Size -> " + sizeof(int) + ", min -> " + int.MinValue + ", max -> " + int.MaxValue);
Console.WriteLine("uint: Size -> " + sizeof(uint) + ", min -> " + uint.MinValue + ", max -> " + uint.MaxValue);
Console.WriteLine("long: Size -> " + sizeof(long) + ", min -> " + long.MinValue + ", max -> " + long.MaxValue);
Console.WriteLine("ulong: Size -> " + sizeof(ulong) + ", min -> " + ulong.MinValue + ", max -> " + ulong.MaxValue);
Console.WriteLine("float: Size -> " + sizeof(float) + ", min -> " + float.MinValue + ", max -> " + float.MaxValue);
Console.WriteLine("double: Size -> " + sizeof(double) + ", min -> " + double.MinValue + ", max -> " + double.MaxValue);
Console.WriteLine("decimal: Size -> " + sizeof(decimal) + ", min -> " + decimal.MinValue + ", max -> " + decimal.MaxValue);


/*Write program to enter an integer number of centuries and convert it to years, days, hours,
minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
type for every data conversion. Beware of overflows!
Input: 1
Output: 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
= 3155673600 seconds = 3155673600000 milliseconds = 3155673600000000
microseconds = 3155673600000000000 nanoseconds
Input: 5
Output: 5 centuries = 500 years = 182621 days = 4382904 hours = 262974240
minutes = 15778454400 seconds = 15778454400000 milliseconds = 15778454400000000
microseconds = 15778454400000000000 nanoseconds*/

int num = Convert.ToInt32(Console.ReadLine());
int year = num * 100;
long days = (long)(year * 365.2422);
long hours = days * 24;
long minutes = hours * 60;
long seconds = minutes * 60;
ulong milliseconds = (ulong)seconds * 1000;
ulong microseconds = milliseconds * 1000;
ulong nanoeconds = microseconds * 1000; 
Console.WriteLine(num + " centuries = " + (year) + " years = " + (days) + " days = " + (hours) + " hours = " +
    (minutes) + " minutes = " + (seconds) + " seconds = " + (milliseconds) +   " milliseconds = " + (microseconds) + " microseconds = " +
    (nanoeconds) + " nanosecond");


//double j = 98;
//double res = j / 0;
//Console.WriteLine(res);

//int i = int.MaxValue;
//int j = i + 1;
//Console.WriteLine(j);

//Exercise03.FizzBuzz();
//Exercise03.TestByteCode();
//Exercise03.GuessNumber();

//PrintAPyramid.Pyramid();
//GuessNumber.Number();

//Birthday.DaysOld();

//Greetings.DayGreetings();
//Increment24.CountIncrement24();

//CopyArray.ArrayCopy();
//GroceryList.groceryList();
//Console.WriteLine(string.Join(", ", PrimeNumbers.PrimeList(1, 20)));
//RotateArray.Sum();

//LongestSquence.LongestSequenceCount();

//FrequentNumber.MostFrequentNumber();
//StringReverse.reverse();

//Palindrome.extractpalindrome();

URLParsing.ParseURL();






