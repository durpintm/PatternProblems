using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Collections.Immutable;

class Program2
{
    static void Main()
    {
        // ArrayList
        // Description: A dynamic array that can hold elements of any type.
        // Namespace: System.Collections
        ArrayList arrayList = new ArrayList { 1, "Hello", 3.14 };
        Console.WriteLine("ArrayList:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // List<T>
        // Description: A dynamic array that provides type safety.
        // Namespace: System.Collections.Generic
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        list.Add(6);
        Console.WriteLine("List<int>:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // Dictionary<TKey, TValue>
        // Description: A collection of key/value pairs with type safety.
        // Namespace: System.Collections.Generic
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary[1] = "One";
        dictionary[2] = "Two";
        Console.WriteLine("Dictionary<int, string>:");
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        Console.WriteLine();

        // Queue<T>
        // Description: A first-in, first-out (FIFO) collection.
        // Namespace: System.Collections.Generic
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        Console.WriteLine("Queue<string>:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
        Console.WriteLine();

        // Stack<T>
        // Description: A last-in, first-out (LIFO) collection.
        // Namespace: System.Collections.Generic
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        Console.WriteLine("Stack<int>:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
        Console.WriteLine();

        // HashSet<T>
        // Description: A collection of unique elements.
        // Namespace: System.Collections.Generic
        HashSet<int> hashSet = new HashSet<int> { 1, 2, 3 };
        hashSet.Add(3); // No effect, 3 is already in the set
        Console.WriteLine("HashSet<int>:");
        foreach (var item in hashSet)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // ConcurrentDictionary<TKey, TValue>
        // Description: A thread-safe collection of key/value pairs.
        // Namespace: System.Collections.Concurrent
        ConcurrentDictionary<int, string> concurrentDictionary = new ConcurrentDictionary<int, string>();
        concurrentDictionary.TryAdd(1, "One");
        concurrentDictionary.TryAdd(2, "Two");
        Console.WriteLine("ConcurrentDictionary<int, string>:");
        foreach (var kvp in concurrentDictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        Console.WriteLine();

        // ConcurrentQueue<T>
        // Description: A thread-safe first-in, first-out (FIFO) collection.
        // Namespace: System.Collections.Concurrent
        ConcurrentQueue<string> concurrentQueue = new ConcurrentQueue<string>();
        concurrentQueue.Enqueue("First");
        concurrentQueue.Enqueue("Second");
        Console.WriteLine("ConcurrentQueue<string>:");
        while (concurrentQueue.TryDequeue(out var item))
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // ConcurrentStack<T>
        // Description: A thread-safe last-in, first-out (LIFO) collection.
        // Namespace: System.Collections.Concurrent
        ConcurrentStack<int> concurrentStack = new ConcurrentStack<int>();
        concurrentStack.Push(1);
        concurrentStack.Push(2);
        Console.WriteLine("ConcurrentStack<int>:");
        while (concurrentStack.TryPop(out var item))
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // NameValueCollection
        // Description: A collection of associated String keys and String values that can handle multiple values for each key.
        // Namespace: System.Collections.Specialized
        NameValueCollection nameValueCollection = new NameValueCollection();
        nameValueCollection.Add("key1", "value1");
        nameValueCollection.Add("key1", "value2"); // Adds another value for key1
        Console.WriteLine("NameValueCollection:");
        foreach (var key in nameValueCollection.AllKeys)
        {
            Console.WriteLine($"{key}: {nameValueCollection[key]}");
        }
        Console.WriteLine();

        // OrderedDictionary
        // Description: A collection of key/value pairs that are accessible by the key or index.
        // Namespace: System.Collections.Specialized
        OrderedDictionary orderedDictionary = new OrderedDictionary();
        orderedDictionary.Add("first", 1);
        orderedDictionary.Add("second", 2);
        Console.WriteLine("OrderedDictionary:");
        foreach (DictionaryEntry entry in orderedDictionary)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
        Console.WriteLine();

        // ImmutableList<T>
        // Description: A list that is immutable and provides methods to create modified copies of the original.
        // Namespace: System.Collections.Immutable
        ImmutableList<int> immutableList = ImmutableList.Create(1, 2, 3);
        ImmutableList<int> newList = immutableList.Add(4);
        Console.WriteLine("ImmutableList<int>:");
        foreach (var item in newList)
        {
            Console.WriteLine(item);
        }
    }
}
