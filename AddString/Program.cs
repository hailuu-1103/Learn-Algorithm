var str1 = "456";
var str2 = "77";
Console.WriteLine(AddStrings(str1, str2));

string AddStrings(string num1, string num2)
{
    var res = "";
    var rem = 0;
    var i   = num1.Length - 1;
    var j   = num2.Length - 1;

    while (i >= 0 || j >= 0 || rem > 0)
    {
        var n1 = i >= 0 ? num1[i] - '0' : 0;
        var n2 = j >= 0 ? num2[j] - '0' : 0;

        var sum = n1 + n2 + rem;
        res += sum % 10;
        rem =  sum / 10;

        i--;
        j--;
    }

    return new(res.Reverse().ToArray());
}