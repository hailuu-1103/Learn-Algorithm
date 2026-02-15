// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public class LFUCache
{
    private Dictionary<int, int> map;
    private Dictionary<int, int> lfu = new();
    private int                  capacity;

    public LFUCache(int capacity)
    {
        this.map      = new(capacity);
        this.capacity = capacity;
    }

    public int Get(int key)
    {

        return 0;
    }

    public void Put(int key, int value) {
    }
}