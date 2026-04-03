//01
using System;

int[] numbers = { 3, 7, 2, 9, 5, 1 };
int sum = 0;

foreach (int num in numbers)
{
    sum += num;
}

Console.WriteLine("Sum = " + sum);



//02

//using System.Linq;

//int[] temps = { 12, -3, 45, 0, 28, -10, 33 };


//int[] tempsCopy = (int[])temps.Clone(); 
//Array.Sort(tempsCopy);
//int minSort = tempsCopy[0];
//int maxSort = tempsCopy[tempsCopy.Length - 1];

//Console.WriteLine($"Способ Sort: Min = {minSort}, Max = {maxSort}");


//int minLoop = temps[0];
//int maxLoop = temps[0];

//foreach (int t in temps)
//{
//    minLoop = Math.Min(minLoop, t);
//    maxLoop = Math.Max(maxLoop, t);
//}

//Console.WriteLine($"Способ Loop: Min = {minLoop}, Max = {maxLoop}");



//03
//using System;

//string[] words = { "apple", "banana", "cherry", "date" };


//string[] wordsCopy = (string[])words.Clone(); 
//Array.Reverse(wordsCopy);
//Console.WriteLine("Array.Reverse: " + string.Join(" ", wordsCopy));


//for (int i = 0; i < words.Length / 2; i++)
//{

//    string temp = words[i];
//    int lastIndex = words.Length - 1 - i;
//    words[i] = words[lastIndex];
//    words[lastIndex] = temp;
//}

//Console.WriteLine("Manual Loop:    " + string.Join(" ", words));



//04
//using System;

//int[] data = { 4, 7, 2, 11, 6, 9, 14, 3, 8 };

//int evenCount = 0;
//int oddCount = 0;


//foreach (int num in data)
//{
//    if (num % 2 == 0) 
//    {
//        evenCount++;
//    }
//    else 
//    {
//        oddCount++;
//    }
//}

//Console.WriteLine("Even = " + evenCount);
//Console.WriteLine("Odd = " + oddCount);


//05
//using System;
//using System.Collections.Generic; 

//int[] raw = { 1, 3, 2, 3, 5, 1, 4, 2, 5 };

//List<int> unique = new List<int>();

//foreach (int num in raw)
//{
//    if (!unique.Contains(num))
//    {
//        unique.Add(num);
//    }
//}

//int[] result = unique.ToArray();

//Console.WriteLine(string.Join(" ", result));



//06
using System;

int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
int k = 3;

int[] rotated = RotateLeft(arr, k);

Console.WriteLine(string.Join(" ", rotated));

static int[] RotateLeft(int[] arr, int k)
{
    int n = arr.Length;

    k = k % n;


    int[] result = new int;

    for (int i = 0; i < n; i++)
    {
        int newIndex = (i + (n - k)) % n;
        result[newIndex] = arr[i];
    }

    return result;
}
