string pattern = "aaa", s = "aa aa aa aa";
Console.WriteLine(WordPattern(pattern, s));

bool WordPattern(string pattern, string s)
{
    var res = true;
    var words = s.Split(' ').AsSpan();
    if (pattern.Length != words.Length) return false;
    var dict = new Dictionary<string, string>();
    for (var i = 0; i < pattern.Length; i++)
    {
        var key = pattern[i].ToString();
        var val = words[i];
        if (i == 0)
        {
            dict.Add(key, val);
        }
        else
        {
            if(!dict.ContainsKey(key))
            {
                dict.Add(key, dict.ContainsValue(val) ? "" : val);
            }
        }
        if (dict[pattern[i].ToString()] != words[i]) res = false;
    }

    return res;
}