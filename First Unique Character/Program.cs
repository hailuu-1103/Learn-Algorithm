static int FirstUniqueChar(string s)
{
    var dictionary = new Dictionary<char, int>();
    foreach (var c in s)
    {
        dictionary[c] = dictionary.GetValueOrDefault(c) + 1;
    }
    for (var i = 0; i < s.Length; i++)
    {
        if (dictionary[s[i]] == 1)
        {
            return i;
        }
    }
    return -1;
}

Console.WriteLine(FirstUniqueChar("leetcode"));
Console.WriteLine(FirstUniqueChar("helloworld"));
Console.WriteLine(FirstUniqueChar("abac"));
Console.WriteLine(FirstUniqueChar(""));