// See https://aka.ms/new-console-template for more information

var cache = new LruCache(2);
cache.Put(1, 1);
// 1: 1-1
// 1-1
cache.Put(2, 2);
// 2: 2-2
// 1: 1-1
Console.WriteLine(cache.Get(1));
cache.Put(3, 3);
Console.WriteLine(cache.Get(2));
cache.Put(4, 4);
Console.WriteLine(cache.Get(1));
Console.WriteLine(cache.Get(3));
Console.WriteLine(cache.Get(4));

public sealed class LruCache
{
    private readonly int                                   capacity;
    private readonly Dictionary<int, LinkedListNode<Node>> map;
    private readonly LinkedList<Node>                      lru;

    private sealed class Node
    {
        public int Key   { get; }
        public int Value { get; set; }

        public Node(int key, int value)
        {
            this.Key = key;
            this.Value  = value;
        }
    }

    public LruCache(int capacity)
    {
        this.capacity = capacity;
        this.map      = new(capacity);
        this.lru      = [];
    }

    public int Get(int key)
    {
        if (!this.map.TryGetValue(key, out var node)) return -1;

        this.lru.Remove(node);
        this.lru.AddFirst(node);

        return node.Value.Value;
    }

    public void Put(int key, int value)
    {
        if (this.map.TryGetValue(key, out var node))
        {
            node.Value.Value = value;
            this.lru.Remove(node);
            this.lru.AddFirst(node);
            return;
        }

        if (this.map.Count == this.capacity)
        {
            var lruNode = this.lru.Last!;
            this.lru.RemoveLast();
            this.map.Remove(lruNode.Value.Key);
        }

        var newNode = new LinkedListNode<Node>(new(key, value));
        this.lru.AddFirst(newNode);
        this.map[key] = newNode;
    }
}