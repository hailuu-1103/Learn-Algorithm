// static int MaxSubarraySum(int[] nums, int k)
// {
//     var maxSum = int.MinValue;
//     for (var i = 0; i < nums.Length; i++)
//     {
//         var j   = i + k;
//         var sum = 0;
//         if (j > nums.Length) continue;
//         for (var l = 0; l < k; l++)
//         {
//             sum += nums[l + i];
//         }
//         maxSum = Math.Max(maxSum, sum);
//     }
//     return maxSum;
// }

static int MaxSubarraySum(int[] nums, int k)
{
    var sum    = 0;
    for (var i = 0; i < k; i++)
    {
        sum += nums[i];
    }
    var maxSum = sum;
    var start  = 0;
    for (var i = k; i < nums.Length; i++)
    {
        sum    = sum - nums[start++] + nums[i];
        maxSum = Math.Max(maxSum, sum);
    }
    return maxSum;
}

// Console.WriteLine(MaxSubarraySum([2, 1, 5, 1, 3, 2], 3));
// Console.WriteLine(MaxSubarraySum([-5, -2, -3, -1], 2));
Console.WriteLine(MaxSubarraySum([7], 1));
// Console.WriteLine(MaxSubarraySum([7, 7, 7], 2));