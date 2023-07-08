class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        // for (var i = 1; i <= n; i++)
        // {
        //     var spaces = new string(' ', n - i);
        //     var hashes = new string('#', i);
        //     Console.WriteLine(spaces + hashes);
        // }

        for (var row = 0; row < n; row++)
        {
            for (var col = 0; col < n; col++)
            {
                Console.Write(col >= n - row - 1 ? "#" : " ");
            }
            Console.WriteLine();
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}