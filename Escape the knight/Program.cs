// ma giáo vãi ò
static string[] ChooseKingMoves(string kingSquare, string knightSquare, int m)
{
    (int c, int r) k = (kingSquare[0] - 97, kingSquare[1] - 49);
    (int c, int r) n = (knightSquare[0] - 97, knightSquare[1] - 49);

    var r = (k.r & ~1 | ((n.c ^ n.r ^ k.c) & 1)) + 1;
    var o = new string[] { $"{(char)((k.c ^ 1) + 97)}{r}", $"{(char)((k.c) + 97)}{r}" };

    return Enumerable.Range(0, m).Select(i => o[i%2]).ToArray();
}

Console.WriteLine(string.Join(", ", ChooseKingMoves("a1", "f3", 20)));