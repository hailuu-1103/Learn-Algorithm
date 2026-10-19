static List<int> merge(List<int> nums1, int m, List<int> nums2, int n)
{
    var result      = new List<int>();
    var isAscending = nums1[1] - nums1[0] >= 0;
    result.AddRange(nums1);
    result.AddRange(nums2);
    return isAscending ? result.OrderBy(x => x).ToList() : result.OrderByDescending(x => x).ToList();
}