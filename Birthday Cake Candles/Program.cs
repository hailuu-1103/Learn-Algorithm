// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

static int birthdayCakeCandles(List<int> candles)
{
    return candles.Count(c => c == candles.Max());
}