// See https://aka.ms/new-console-template for more information

Console.WriteLine(Fib(30));

int Fib(int n)
{
    return n switch
    {
        0 => 0,
        1 => 1,
        _ => Fib(n - 1) + Fib(n - 2),
    };
}