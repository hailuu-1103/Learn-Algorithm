int[][] matrix =
{
    [1, 1, 0],
    [1, 1, 0],
    [0, 0, 1],
};
Console.WriteLine(FindCircleNum(matrix));

int FindCircleNum(int[][] isConnected)
{
    var len     = isConnected.Length;
    var visited = new bool[len];
    var count   = 0;

    void DFS(int city)
    {
        visited[city] = true;
        for (var neighbor = 0; neighbor < len; neighbor++)
        {
            if(!visited[neighbor] && isConnected[city][neighbor] == 1)
                DFS(neighbor);
        }
    }

    for (var city = 0; city < len; city++)
    {
        if (!visited[city])
        {
            count++;
            DFS(city);
        }
    }
    return count;
}