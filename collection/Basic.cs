/*using System;
using System.Collections;
using System.Collections.Concurrent;

//array -> stores fixed-size sequential collection of elements of the same type
int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
System.Console.WriteLine("This is from array: ");
foreach (int i in numbers)
{
    Console.WriteLine(i);
}

//string -> stores fixed-size sequential collection of characters
string[] names = new string[3] { "John", "Jane", "Doe" };
Console.WriteLine("This is from string array: ");
foreach (string name in names)
{
    Console.WriteLine(name);
}

//list -> stores variable-size sequential collection of elements of the same type
List<string> fruits = new List<string>() { "Apple", "Banana", "Cherry" };
Console.WriteLine("This is from list: ");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
fruits.Add("Mango");
fruits.Remove("Banana");

Console.WriteLine("After adding and removing fruits: ");
foreach (string f in fruits)
{
    Console.WriteLine(f);
}

//dictionary -> stores variable-size collection of key-value pairs
Dictionary<string, int> ages = new Dictionary<string, int>()
            {
                { "John", 25 },
                { "Jane", 30 },
                { "Doe", 35 }
            };
Console.WriteLine("This is from dictionary: ");
foreach (var kvp in ages)
{
    Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
}

// ArrayList -> stores variable-size sequential collection of elements of different types
ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add("Harry");
arrayList.Add("Cherry");
arrayList.Add("Merry");
arrayList.Add(2);
Console.WriteLine("This is from ArrayList: ");
foreach (var item in arrayList)
{
    Console.WriteLine(item);
}
arrayList.Remove("Merry");
Console.WriteLine("After removing 'Merry' from ArrayList: ");
foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

// Stack -> stores variable-size collection of elements in a last-in-first-out (LIFO) manner
Stack stack = new Stack();
stack.Push(1);
stack.Push(2);
stack.Push(3);
Console.WriteLine("This is from Stack: ");
foreach (var item in stack)
{
    Console.WriteLine(item);
}
stack.Pop();
Console.WriteLine("After popping from Stack: ");
foreach (var item in stack)
{
    Console.WriteLine(item);
}

// Queue -> stores variable-size collection of elements in a first-in-first-out (FIFO) manner
Queue queue = new Queue();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
Console.WriteLine("This is from Queue: ");
foreach (var item in queue)
{
    Console.WriteLine(item);
}
queue.Dequeue();
Console.WriteLine("After dequeuing from Queue: ");
foreach (var item in queue)
{
    Console.WriteLine(item);
}

// HashTable -> stores variable-size collection of key-value pairs
Hashtable hashtable = new Hashtable();
hashtable.Add("Alice", 40);
hashtable.Add("John", 25);
hashtable.Add("Jane", 30);
hashtable.Add("Doe", 35);
Console.WriteLine("This is from HashTable: ");
foreach (DictionaryEntry entry in hashtable)
{
    Console.WriteLine($"Name: {entry.Key}, Age: {entry.Value}");
}

// SortedList -> stores variable-size collection of key-value pairs in sorted order
SortedList sortedList = new SortedList();
sortedList.Add("John", 25);
sortedList.Add("Jane", 30);
sortedList.Add("Alice", 40);
sortedList.Add("Doe", 35);
Console.WriteLine("This is from SortedList: ");
foreach (DictionaryEntry entry in sortedList)
{
    Console.WriteLine($"Name: {entry.Key}, Age: {entry.Value}");
}

// Generic Collections
// List<T> -> stores variable-size sequential collection of elements of the same type
List<int> genericList = new List<int>() { 1, 2, 3, 4, 5 };
Console.WriteLine("This is from generic List<T>: ");
foreach (var item in genericList)
{
    Console.WriteLine(item);
}

// stack<T> -> stores variable-size collection of elements in a last-in-first-out (LIFO) manner
Stack<string> genericStack = new Stack<string>();
genericStack.Push("First");
genericStack.Push("Second");
genericStack.Push("Third");
Console.WriteLine("This is from generic Stack<T>: ");
foreach (var item in genericStack)
{
    Console.WriteLine(item);
}
genericStack.Pop();
Console.WriteLine("After popping from generic Stack<T>: ");
foreach (var item in genericStack)
{
    Console.WriteLine(item);
}

// Queue<T> -> stores variable-size collection of elements in a first-in-first-out (FIFO) manner
Queue<double> genericQueue = new Queue<double>();
genericQueue.Enqueue(1.1);
genericQueue.Enqueue(2.2);
genericQueue.Enqueue(3.3);
Console.WriteLine("This is from generic Queue<T>: ");
foreach (var item in genericQueue)
{
    Console.WriteLine(item);
}

genericQueue.Dequeue();
Console.WriteLine("After dequeuing from generic Queue<T>: ");
foreach (var item in genericQueue)
{
    Console.WriteLine(item);
}

// HashSet<T> -> stores variable-size collection of unique elements of the same type
HashSet<string> genericHashSet = new HashSet<string>() { "Apple", "Banana", "Cherry" };
Console.WriteLine("This is from generic HashSet<T>: ");
foreach (var item in genericHashSet)
{
    Console.WriteLine(item);
}

// Dictionary<TKey, TValue> -> stores variable-size collection of key-value pairs
Dictionary<string, string> genericDictionary = new Dictionary<string, string>()
            {
                { "John", "25" },
                { "Jane", "30" },
                { "Doe", "35" }
            };
Console.WriteLine("This is from generic Dictionary<TKey, TValue>: ");
foreach (var kvp in genericDictionary)
{
    Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
}

// SortedList<TKey, TValue> -> stores variable-size collection of key-value pairs in sorted order
SortedList<string, int> genericSortedList = new SortedList<string, int>()
            {
                { "John", 25 },
                { "Jane", 30 },
                { "Alice", 40 },
                { "Doe", 35 }
            };
Console.WriteLine("This is from generic SortedList<TKey, TValue>: ");
foreach (var kvp in genericSortedList)
{
    Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
}

// SortedSet<T> -> stores variable-size collection of unique elements of the same type in sorted order
SortedSet<int> genericSortedSet = new SortedSet<int>() { 5, 3, 1, 4, 2 };
Console.WriteLine("This is from generic SortedSet<T>: ");
foreach (var item in genericSortedSet)
{
    Console.WriteLine(item);
}

// SortedSet<T> with custom comparer -> stores variable-size collection of unique elements of the same type in sorted order with custom comparison logic
SortedSet<string> customSortedSet = new SortedSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "banana",
                "Apple",
                "cherry"
            };
Console.WriteLine("This is from generic SortedSet<T> with custom comparer: ");
foreach (var item in customSortedSet)
{
    Console.WriteLine(item);
}

// SortedDictionary<TKey, TValue> -> stores variable-size collection of key-value pairs in sorted order
SortedDictionary<string, int> genericSortedDictionary = new SortedDictionary<string, int>()
            {
                { "John", 25 },
                { "Jane", 30 },
                { "Alice", 40 },
                { "Doe", 35 }
            };
Console.WriteLine("This is from generic SortedDictionary<TKey, TValue>: ");
foreach (var kvp in genericSortedDictionary)
{
    Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
}

// LinkedList<T> -> stores variable-size collection of elements in a doubly-linked list
LinkedList<string> genericLinkedList = new LinkedList<string>();
genericLinkedList.AddLast("First");
genericLinkedList.AddLast("Second");
genericLinkedList.AddLast("Third");
Console.WriteLine("This is from generic LinkedList<T>: ");
foreach (var item in genericLinkedList)
{
    Console.WriteLine(item);
}

// Concurrent Collections
// ConcurrentDictionary<TKey, TValue> -> thread-safe collection for key-value pairs
ConcurrentDictionary<string, int> concurrentDictionary = new ConcurrentDictionary<string, int>();
concurrentDictionary.TryAdd("John", 25);
concurrentDictionary.TryAdd("Jane", 30);
Console.WriteLine("This is from ConcurrentDictionary<TKey, TValue>: ");
foreach (var kvp in concurrentDictionary)
{
    Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
}

// ConcurrentQueue<T> -> First-In-First-Out (FIFO) thread-safe collection
ConcurrentQueue<string> concurrentQueue = new ConcurrentQueue<string>();
concurrentQueue.Enqueue("First");
concurrentQueue.Enqueue("Second");
concurrentQueue.Enqueue("Third");
Console.WriteLine("This is from ConcurrentQueue<T>: ");
foreach (var item in concurrentQueue)
{
    Console.WriteLine(item);
}

// ConcurrentStack<T> -> Last-In-First-Out (LIFO) thread-safe collection
ConcurrentStack<string> concurrentStack = new ConcurrentStack<string>();
concurrentStack.Push("First");
concurrentStack.Push("Second");
concurrentStack.Push("Third");
Console.WriteLine("This is from ConcurrentStack<T>: ");
foreach (var item in concurrentStack)
{
    Console.WriteLine(item);
}
concurrentStack.TryPop(out string poppedItem);
Console.WriteLine($"After popping from ConcurrentStack<T>: {poppedItem}");

// ConcurrentBag<T> -> Unordered thread-safe collection that allows duplicates
ConcurrentBag<int> concurrentBag = new ConcurrentBag<int>();
concurrentBag.Add(1);
concurrentBag.Add(2);
concurrentBag.Add(3);
Console.WriteLine("This is from ConcurrentBag<T>: ");
foreach (var item in concurrentBag)
{
    Console.WriteLine(item);
}

// BlockingCollection<T> -> thread-safe collection that provides blocking and bounding capabilities
BlockingCollection<string> blockingCollection = new BlockingCollection<string>();
blockingCollection.Add("First");
blockingCollection.Add("Second");
blockingCollection.Add("Third");
Console.WriteLine("This is from BlockingCollection<T>: ");
foreach (var item in blockingCollection)
{
    Console.WriteLine(item);
}


//LINQ -> Language Integrated Query 
// used to query collections in a more readable and concise way
// LINQ to filter a list of 
// WHERE -> FILTERING
// SELECT -> PROJECTING/ CONERTING ONE TYPE TO ANOTHER
// ORDERBY -> SORTING

List<int> linqNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var evenNumbers = from num in linqNumbers
                  where num % 2 == 0
                  select num;
Console.WriteLine("Even numbers (using LINQ): ");
foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}

ArrayList linqArrayList = new ArrayList();
linqArrayList.Add("apple");
linqArrayList.Add("banana");
linqArrayList.Add("cherry");
var upperCaseFruits = from string fruit in linqArrayList
                      select fruit.ToUpper();
Console.WriteLine("Fruits in upper case (using LINQ): ");
foreach (var fruit in upperCaseFruits)
{
    Console.WriteLine(fruit);
}

linqArrayList.Cast<string>()
    .Select(fruit => fruit
    .ToString()
    .ToUpper())
    .ToList()
    .ForEach(fruit => Console.WriteLine(fruit));
*/