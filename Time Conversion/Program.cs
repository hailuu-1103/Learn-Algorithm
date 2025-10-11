// See https://aka.ms/new-console-template for more information


var s       = "00:24:00AM";
var s1       = "12:24:00AM";
var s2       = "07:24:00PM";
var s3       = "00:24:00PM";
var s4       = "11:24:00PM";

Console.WriteLine(timeConversion(s));
Console.WriteLine(timeConversion(s1));
Console.WriteLine(timeConversion(s2));
Console.WriteLine(timeConversion(s3));
Console.WriteLine(timeConversion(s4));
static string timeConversion(string s)
{
    var    parts   = s.Split(":");
    var    isDay   = s[^2..] == "AM";
    var    hourVal = int.Parse(parts[0]);
    var hours   = isDay ? hourVal == 12 ? "00" : $"0{hourVal}" : hourVal == 12 ? "12" : (hourVal+12).ToString();
    var minutes = parts[1];
    var seconds = isDay ? parts[2].Replace("AM", "") : parts[2].Replace("PM", "");
    return hours + ":" + minutes + ":" + seconds;
}

