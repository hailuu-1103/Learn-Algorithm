// See https://aka.ms/new-console-template for more information

int[] arr = [2, 2];
var   res = FindErrorNums(arr);
foreach (var item in res)
{
    Console.WriteLine(item);
}

static int[] FindErrorNums(int[] nums)
{
    var n   = nums.Length;
    var cnt = new int[n + 1];
    foreach (var x in nums) cnt[x]++;
    var dup     = -1;
    var missing = -1;
    for (var i = 1; i <= n; i++)
    {
        if (cnt[i] == 2)
        {
            dup = i;
        }
        else if (cnt[i] == 0) missing = i;
    }

    return [dup, missing];
}