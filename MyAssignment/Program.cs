static int modulus3(uint n)
{
    return n - 3 * (n / 3) == 0 ? 1 : 0;
}

static int topK(int[] nums, int k)
{
    for (var i = 0; i < k; i++)
    {
        var maxIndex = i;

        for (var j = i + 1; j < nums.Length; j++)
        {
            if (nums[j] > nums[maxIndex])
            {
                maxIndex = j;
            }
        }

        (nums[i], nums[maxIndex]) = (nums[maxIndex], nums[i]);
    }

    return nums[k - 1];
}

// return -1: unfinish
// return 0: draw
// return 1: O win
// return 2: X win
static int ticTacToeResult(int[,] board)
{
    for (var i = 0; i < 3; i++)
    {
        if (board[i, 0] != 0
            && board[i, 0] == board[i, 1]
            && board[i, 1] == board[i, 2])
        {
            return board[i, 0];
        }

        if (board[0, i] != 0
            && board[0, i] == board[1, i]
            && board[1, i] == board[2, i])
        {
            return board[0, i];
        }
    }

    if (board[0, 0] != 0
        && board[0, 0] == board[1, 1]
        && board[1, 1] == board[2, 2])
    {
        return board[0, 0];
    }

    if (board[0, 2] != 0
        && board[0, 2] == board[1, 1]
        && board[1, 1] == board[2, 0])
    {
        return board[0, 2];
    }

    for (var row = 0; row < 3; row++)
    {
        for (var col = 0; col < 3; col++)
        {
            if (board[row, col] == 0) return 0;
        }
    }

    return -1;
}

Console.WriteLine($"Output1: {modulus3(5)}");
Console.WriteLine($"Output1: {modulus3(6)}");
Console.WriteLine($"Output2: {topK([3, 2, 1, 5, 6, 4], 2)}");
Console.WriteLine($"Output2: {topK([3, 2, 13, 14, 1, 5, 6, 4, 7, 8, 9, 10, 12], 3)}");