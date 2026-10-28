static int LengthOfLongestSubstring(string s)
{
    var seen      = new HashSet<char>();
    var left      = 0;
    var maxLength = 0;
    for (var right = 0; right < s.Length; right++)
    {
        while (seen.Contains(s[right]))
        {
            seen.Remove(s[left]);
            left++;
        }
        seen.Add(s[right]);
        maxLength = Math.Max(maxLength, right - left + 1);
    }

    return maxLength;
}

Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
Console.WriteLine(LengthOfLongestSubstring("bbbbb"));
Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
Console.WriteLine(LengthOfLongestSubstring(""));