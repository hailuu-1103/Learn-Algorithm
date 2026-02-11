// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
int[] arr = [1, 1, 0, 1];
Console.WriteLine(FindMaxConsecutiveOnes(arr));

static int FindMaxConsecutiveOnes(int[] nums)
{
    var best = 0;
    var cur  = 0;

    foreach (var x in nums)
    {
        if (x == 1)
        {
            cur++;
            if (cur > best) best = cur;
        }
        else
        {
            cur = 0;
        }
    }
    return best;
}