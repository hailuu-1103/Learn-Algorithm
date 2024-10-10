static string AddBinary(int a, int b)
{
    return Convert.ToString(a + b, 2);
}


Console.WriteLine(AddBinary(1,2));