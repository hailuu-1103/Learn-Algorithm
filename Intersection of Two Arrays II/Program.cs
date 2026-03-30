var nums1     = new[] { 3, 1, 2 };
var nums2     = new[] { 1, 2, 3 };
var intersect = Intersect(nums1, nums2);
foreach (var inter in intersect)
{
    Console.WriteLine(inter);
}

int[] Intersect(int[] nums1, int[] nums2)
{
    var result = new List<int>();
    var dict1   = new Dictionary<int, int>();
    foreach (var n in nums1)
    {
        if (!dict1.TryAdd(n, 1))
        {
            dict1[n]++;
        }
    }

    var dict2 = new Dictionary<int, int>();
    foreach (var n in nums2)
    {
        if (!dict2.TryAdd(n, 1))
        {
            dict2[n]++;
        }
    }

    foreach (var kvp in dict1)
    {
        if (!dict2.TryGetValue(kvp.Key, out var value)) continue;
        for (var i = 0; i < Math.Min(kvp.Value, value); i++)
        {
            result.Add(kvp.Key);
        }
    }
    return result.ToArray();
}