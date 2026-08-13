using System;
using System.Collections.Generic;

namespace HashmapApp.Problems;

public class CustomHashMap<TKey, TValue>
{
    private readonly LinkedList<Entry>[] buckets;

    public CustomHashMap(int capacity)
    {
        if (capacity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(capacity));
        }

        buckets = new LinkedList<Entry>[capacity];
    }

    public int Count { get; private set; }

    public void Add(TKey key, TValue value)
    {
        var index = GetBucketIndex(key);
        if (buckets[index] == null)
        {
            buckets[index] = new LinkedList<Entry>();
        }

        var node = FindNode(buckets[index], key);
        if (node != null)
        {
            node.Value.Value = value;
            return;
        }

        buckets[index].AddLast(new Entry(key, value));
        Count++;
    }

    public TValue Get(TKey key)
    {
        var index = GetBucketIndex(key);
        var node = FindNode(buckets[index], key);
        if (node == null)
        {
            throw new KeyNotFoundException($"Key '{key}' was not found.");
        }

        return node.Value.Value;
    }

    public bool ContainsKey(TKey key)
    {
        var index = GetBucketIndex(key);
        return FindNode(buckets[index], key) != null;
    }

    public void Remove(TKey key)
    {
        var index = GetBucketIndex(key);
        if (buckets[index] == null)
        {
            return;
        }

        var node = FindNode(buckets[index], key);
        if (node == null)
        {
            return;
        }

        buckets[index].Remove(node);
        Count--;
    }

    private int GetBucketIndex(TKey key)
    {
        var hash = key?.GetHashCode() ?? 0;
        return Math.Abs(hash) % buckets.Length;
    }

    private static LinkedListNode<Entry>? FindNode(LinkedList<Entry>? bucket, TKey key)
    {
        if (bucket == null)
        {
            return null;
        }

        var current = bucket.First;
        while (current != null)
        {
            if (EqualityComparer<TKey>.Default.Equals(current.Value.Key, key))
            {
                return current;
            }

            current = current.Next;
        }

        return null;
    }

    public class Entry
    {
        public Entry(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public TKey Key { get; }
        public TValue Value { get; set; }
    }
}
