// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
int[] arr = [2, 5, 1, 3, 4, 7];
var   res = Shuffle(arr, 3);
foreach (var item in res)
{
    Console.WriteLine(item);
}

static int[] Shuffle(int[] nums, int n)
{
    var res = new int[2 * n];
    for (var i = 0; i < n; i++)
    {
        res[2 * i]     = nums[i];
        res[2 * i + 1] = nums[i + n];
    }
    return res;
}