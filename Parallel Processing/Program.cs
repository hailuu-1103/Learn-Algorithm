class Result
{

    /*
     * Complete the 'minTime' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY files
     *  2. INTEGER numCores
     *  3. INTEGER limit
     */

    public static long minTime(List<int> files, int numCores, int limit)
    {
        var result = 0;
        if (numCores == 1)
        {
            result += files.Sum();
        }
        else
        {
            var coreUsed = 0;
            foreach (var file in files)
            {
                if (file % limit == 0 && coreUsed <= numCores)
                {
                    result   += (file/limit);
                    coreUsed += 1;
                }
                else
                {
                    result += file;
                }
            }
        }
        
        return result;
    }
}
class Solution
{
    public static void Main(string[] args)
    {

        int filesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> files = new List<int>();

        for (int i = 0; i < filesCount; i++)
        {
            int filesItem = Convert.ToInt32(Console.ReadLine().Trim());
            files.Add(filesItem);
        }

        int numCores = Convert.ToInt32(Console.ReadLine().Trim());

        int limit = Convert.ToInt32(Console.ReadLine().Trim());

        long result = Result.minTime(files, numCores, limit);

        Console.WriteLine(result);
    }
}