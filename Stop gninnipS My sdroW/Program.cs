string SpinWords(string sentence)
{
    var words = sentence.Split(' ');
    for (var i = 0; i < words.Length; i++)
    {
        if (words[i].Length >= 5)
        {
            words[i] = new(words[i].Reverse().ToArray());
        }
    }
    return string.Join(" ", words);
}
Console.WriteLine(SpinWords("Hey fellow warriors"));
Console.WriteLine(SpinWords("This is another test"));
Console.WriteLine(SpinWords("You are almost to the last test"));
Console.WriteLine(SpinWords("Just kidding there is still one more"));
