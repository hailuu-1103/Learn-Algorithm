// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
int[] arr = [1, 2, 3, 4];
var   res = GetConcatenation(arr);
foreach (var item in res)
{
    Console.WriteLine(item);
}
static int[] GetConcatenation(int[] nums) {
    return nums.Concat(nums).ToArray();
}