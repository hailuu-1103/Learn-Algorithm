var arr = new[] { 1, 3, 5, 6 };
Console.WriteLine(SearchInsert(arr, 0));

int SearchInsert(int[] nums, int target)
{
    if (nums.Contains(target)) return nums.IndexOf(target);
    if (nums.Min() > target) return 0;
    if (nums.Max() < target) return nums.Length;
    var res = 0;
    for (var i = 0; i < nums.Length - 1; i++)
    {
        if (target < nums[i] || target >= nums[i + 1]) continue;
        res = i + 1;
        break;
    }
    return res;
}