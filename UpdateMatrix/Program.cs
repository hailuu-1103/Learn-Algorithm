using System.Numerics;

var mat = new int[][] { [0, 0, 0], [0, 1, 0], [1, 1, 1] };
mat = UpdateMatrix(mat);
for (var i = 0; i < 3; i++)
{
    for (var j = 0; j < 3; j++)
    {
        Console.Write(mat[i][j]);
    }
    Console.WriteLine();
}

int[][] UpdateMatrix(int[][] mat)
{
    var res = new int[mat.Length][];

    return BFS(mat, 1, 1);

    int[][] BFS(int[][] grid, int x, int y)
    {
        var rows    = grid[0].Length;
        var cols    = grid[0].Length;
        var dist    = new int[rows][];
        var visited = new bool[rows][];

        var dirs = new int[][]
        {
            [0, 1],  //top
            [0, -1], //bot
            [-1, 0], //left
            [1, 0],  //right
        };

        for (var i = 0; i < rows; i++)
        {
            dist[i]    = new int[rows];
            visited[i] = new bool[rows];

            for (var j = 0; j < rows; j++)
            {
                dist[i][j] = -1;
            }
        }

        var queue = new Queue<(int row, int col)>();
        queue.Enqueue((x, y));
        visited[x][y] = true;
        dist[x][y]    = 0;
        while (queue.Count > 0)
        {
            var (row, col) = queue.Dequeue();
            foreach (var dir in dirs)
            {
                var newRow = row + dir[0];
                var newCol = col + dir[1];
                if (!IsInside(newRow, newCol)) continue;
                if (visited[newRow][newCol]) continue;
                visited[newRow][newCol] = true;
                dist[newRow][newCol]    = dist[row][col] + 1;
                queue.Enqueue((newRow, newCol));
            }
        }

        bool IsInside(int x, int y)
        {
            return x >= 0 && y >= 0 && x < rows && y < cols;
        }

        return dist;
    }
}