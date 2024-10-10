// return masked string
static string Maskify(string cc)
{
    return cc[(cc.Length < 4 ? 0 : cc.Length - 4)..].PadLeft(cc.Length, '#');
}

Console.WriteLine(Maskify("4556364607935616"));