var words = new[]
{
    "cool",
    "lock",
    "cook",
};
var res = CommonChars(words);
foreach (var word in res)
{
    Console.WriteLine(word);
}

IList<string> CommonChars(string[] words)
{
    var common = new int[26];
    for (var i = 0; i < words[0].Length; i++)
    {
        common[words[0][i] - 'a']++;
    }
    for (var i = 1; i < words.Length; i++)
    {
        var count = new int[26];
        for (var j = 0; j < words[i].Length; j++)
        {
            count[words[i][j] - 'a']++;
        }

        for (var j = 0; j < 26; j++)
        {
            common[j] = Math.Min(common[j], count[j]);
        }
    }
    var result = new List<string>();
    var idx    = 0;
    while (idx < 26)
    {
        if (common[idx] == 0)
        {
            idx++;
            continue;
        }
        for (var i = 0; i < common[idx]; i++)
        {
            result.Add(((char)(idx + 'a')).ToString());
        }
        idx++;
    }
    return result;
}