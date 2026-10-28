static int[][] MergeIntervals(int[][] intervals)
{
    switch (intervals.Length)
    {
        case 0: return intervals;
        case 1: return [[intervals[0][0], intervals[0][1]]];
    }
    var results = new List<int[]>();
    intervals = intervals.OrderBy(i => i[0]).ToArray();
    var start = intervals[0][0];
    var end   = intervals[0][1];
    for (var i = 1; i < intervals.Length; i++)
    {
        var nextStart = intervals[i][0];
        var nextEnd   = intervals[i][1];
        if (end >= nextStart)
        {
            end = Math.Max(end, nextEnd);
        }
        else
        {
            results.Add([start, end]);
            start = nextStart;
            end   = nextEnd;
        }
    }
    results.Add([start, end]);
    return results.ToArray();
}

var testcases = new int[][][]
{
    [[8, 10], [1, 3], [15, 18], [2, 6]],
    [[1, 4], [5, 6]],
    [[1, 10], [2, 3]], [],
};
foreach (var testCase in testcases)
{
    var output = MergeIntervals(testCase);
    Console.WriteLine("Output: ");
    foreach (var interval in output)
    {
        Console.Write($"[{interval[0]} {interval[1]}] ");
    }
    Console.WriteLine("");
}