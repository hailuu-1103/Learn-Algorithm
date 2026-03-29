Console.WriteLine(IsPalindrome(1231));

bool IsPalindrome(int x)
{
    if (x < 0) return false;
    var str = "";
    var tmp = x;
    while (tmp > 0)
    {
        str += tmp % 10;
        tmp /= 10;
    }
    var res = true;
    for (var i = 0; i < str.Length / 2; i++)
    {
         res &= str[i] == str[str.Length - 1 - i];
    }
    return res;
}