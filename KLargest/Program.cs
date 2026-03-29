var k    = 3;
var nums = new[] { 4, 5, 8, 2 };
// (4,4)
// (4,4) (5,5)
// (4,4) (5,5) (8,8)
// (4,4) (5,5) (8,8) -> 4
// (5,5) (5,5) (8,8) -> 5
// (5,5) (8,8) (10,10) -> 5
// (8,8) (9,9) (10,10) -> 8
// (8,8) (9,9) (10,10) -> 8
var obj  = new KthLargest(k, nums);
Console.WriteLine(obj.Add(3));
Console.WriteLine(obj.Add(5));
Console.WriteLine(obj.Add(10));
Console.WriteLine(obj.Add(9));
Console.WriteLine(obj.Add(4));

public class KthLargest
{
    private PriorityQueue<int, int> nums = new();
    private int                     k;

    public KthLargest(int k, int[] nums)
    {
        this.k = k;
        foreach (var num in nums)
        {
            this.Add(num);
        }
    }

    public int Add(int val)
    {
        this.nums.Enqueue(val, val);
        if (this.nums.Count > this.k)
        {
            this.nums.Dequeue();
        }
        return this.nums.Peek();
    }
}