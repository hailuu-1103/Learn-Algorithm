// See https://aka.ms/new-console-template for more information

var a = new List<int>
{
    3, 1, 2,
};

var b = new List<int>
{
    2, 2, 2,
};

var c = 3;
Console.WriteLine(travelAroundTheWorld(a, b, c));

/*
 * 3 3
   3 1 2
   2 2 2

   3
   4 1 2
   2 2 2

   2
*/

static int travelAroundTheWorld(List<int> a, List<int> b, long c)
{
    var ok = 0;
    var n  = a.Count;

    for (var start = 0; start < n; start++)
    {
        long fuel = 0;
        var can  = true;

        for (var step = 0; step < n; step++)
        {
            var i = (start + step) % n;
            fuel =  Math.Min(fuel + a[i], c);
            fuel -= b[i];

            if (fuel < 0)
            {
                can = false;
                break;
            }
        }

        if (can) ok++;
    }

    return ok;
}