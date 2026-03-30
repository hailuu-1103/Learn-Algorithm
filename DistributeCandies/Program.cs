// See https://aka.ms/new-console-template for more information

var arr = new int[]
{
    1, 1, 2, 3,
};
Console.WriteLine(DistributeCandies(arr));

int DistributeCandies(int[] candyType)
{
    var dict = new Dictionary<int, int>();
    foreach (var t in candyType)
    {
        if (!dict.TryAdd(t, 1))
        {
            dict[t]++;
        }
    }
    return Math.Min(candyType.Length / 2, dict.Count);
}