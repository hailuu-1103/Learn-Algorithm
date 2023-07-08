// *** Snake Matrix
// Given matrix 
// 1 2 3 2 
// 1 4 8 7 
// 1 2 0 7 
// 
// Target list
// 1 2 3 2 7 7 0 2 1 1 4 8 
// 
// Write a list from 2D array that represent the 2D array in spiral order

var given = new[,]
{
    { 1, 2, 3, 2 },
    { 1, 4, 8, 7},
    { 1, 2, 0, 7},
};

var result = new List<int>();

var rowStart = 0;
var rowEnd   = given.GetLength(0) - 1;
var colStart = 0;
var colEnd   = given.GetLength(1) - 1;
while (rowStart <= rowEnd && colStart <= colEnd)
{
    // -> -> -> ->
    for (var col = colStart; col <= colEnd; col++)
    {
        result.Add(given[rowStart, col]);
    }

    rowStart += 1;
    // V
    // V
    // V
    // V
    for (var row = rowStart; row <= rowEnd; row++)
    {
        result.Add(given[row, colEnd]);
    }

    colEnd -= 1;
    // < < < <
    for (var col = colEnd; col >= colStart; col--)
    {
        result.Add(given[rowEnd, col]);
    }
    
    rowEnd -= 1;
    // ^
    // ^
    // ^
    // ^
    for (var row = rowEnd; row >= rowStart; row--)
    {
        result.Add(given[row, colStart]);
    }

    colStart += 1;
}

result.RemoveAt(result.Count -1);
foreach (var element in result)
{
    Console.Write(element + " ");
}