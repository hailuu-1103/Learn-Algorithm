// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
int[] n1 = [8, 1, 2, 2, 3];
int[] n2 = [6, 5, 4, 8];
int[] n3 = [7, 7, 7, 7];
foreach (var i in SmallerNumbersThanCurrent(n1))
{
    Console.WriteLine("hehe: " + i);
}

static int[] SmallerNumbersThanCurrent(int[] nums)
{
    var n      = nums.Length;
    var sorted = (int[])nums.Clone();
    Array.Sort(sorted);

    var firstIndex = new Dictionary<int, int>(n);
    for (var i = 0; i < n; i++) firstIndex.TryAdd(sorted[i], i);

    var result                            = new int[n];
    for (var i = 0; i < n; i++) result[i] = firstIndex[nums[i]];

    return result;
}