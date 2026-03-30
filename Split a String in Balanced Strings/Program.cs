// See https://aka.ms/new-console-template for more information

Console.WriteLine(BalancedStringSplit("RLRRLLRLRL"));

int BalancedStringSplit(string s)
{
    var result = 0;
    var count  = 0;
    foreach (var c in s)
    {
        switch (c)
        {
            case 'R': count++; break;
            case 'L': count--; break;
        }
        if (count == 0)
        {
            result++;
        }
    }
    return result;
}