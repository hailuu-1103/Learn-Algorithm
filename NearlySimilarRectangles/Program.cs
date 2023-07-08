

class Solution
{
    private static long nearlySimilarRectangles(List<List<long>> sides)
    {
        long     result     = -1;
        var sidesArray = sides.Select(list => list.ToArray().ToArray()).ToArray();
        var      rows       = sidesArray.GetLength(0);
        var      cols       = sidesArray[0].Length;
        
        for (var row = 0; row < rows; row++)
        {
            for (var col = 0; col < cols; col++)
            {
                for (var nextRow = row + 1; nextRow < rows; nextRow++)
                {
                    for (var nextCol = col + 1; nextCol < cols; nextCol++)
                    {
                        if((float)(sidesArray[row][col] / sidesArray[nextRow][col]) - (float)(sidesArray[row][nextCol] / sidesArray[nextRow][nextCol]) < float.Epsilon )
                        {
                            result += 1;
                        }
                    }
                }        
            }
        }
        
        return result;
    }
    public static void Main(string[] args)
    {

        int sidesRows    = Convert.ToInt32(Console.ReadLine().Trim());
        int sidesColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<long>> sides = new List<List<long>>();

        for (int i = 0; i < sidesRows; i++)
        {
            sides.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sidesTemp => Convert.ToInt64(sidesTemp)).ToList());
        }

        var result = nearlySimilarRectangles(sides);

        Console.WriteLine(result);     
    }
}
