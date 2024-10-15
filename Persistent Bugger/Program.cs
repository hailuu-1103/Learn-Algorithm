static int Persistence(long n)
{
    if (n < 10) return 0;
    var count  = 0;
    var temp   = n;
    
    while (temp >= 10)
    {
        temp  =  GetDigitMul(temp);
        count += 1;
    }

    return count;

    int GetDigitMul(long value)
    {
        var result = 1;
        while (value > 0)
        {
            var digit = value % 10; 
            result *= (int)digit;        
            value  /= 10;            
        }

        return result;
    }
}

Console.WriteLine($"Count: {Persistence(39)}");
Console.WriteLine($"Count: {Persistence(4)}");
Console.WriteLine($"Count: {Persistence(25)}");
Console.WriteLine($"Count: {Persistence(999)}");
Console.WriteLine($"Count: {Persistence(123)}");