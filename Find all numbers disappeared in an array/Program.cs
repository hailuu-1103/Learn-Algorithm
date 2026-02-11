// See https://aka.ms/new-console-template for more information

int[] n1 = [4, 3, 2, 7, 8, 2, 3, 1];
foreach (var x in FindDisappearedNumbers(n1))
{
    Console.WriteLine($"hehe: {x}");
}

static IList<int> FindDisappearedNumbers(int[] nums)
{
    var n   = nums.Length;
    var cnt = new int[n + 1];
    foreach (var x in nums) cnt[x]++;
    var missing = new List<int>();
    for (var i = 1; i <= n; i++)
    {
        if (cnt[i] == 0) missing.Add(i);
    }
    return missing;
}