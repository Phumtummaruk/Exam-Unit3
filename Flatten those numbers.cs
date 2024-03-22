using System;
using System.Collections;
using System.Collections.Generic;

public class ArrayFlattener
{
    public static List<int> FlattenArray(List<object> array)
    {
        List<int> flattened = new List<int>();
        foreach (var item in array)
        {
            if (item is int)
            {
                flattened.Add((int)item);
            }
            else if (item is List<object>)
            {
                flattened.AddRange(FlattenArray((List<object>)item));
            }
            else
            {
                throw new ArgumentException("Invalid item type in the array.");
            }
        }
        return flattened;
    }

    public static void Main(string[] args)
    {
        List<object> nestedArray = new List<object> {
            6410,
            2831,
            5049,
            7554,
            new List<object> {
                8707,
                6940,
                9517,
                7565,
                7522,
                9242,
                7972,
                7064,
                3441,
                new List<object> {
                    9960,
                    4966,
                    9368,
                    1634,
                    5150,
                    3709,
                    6660,
                    new List<object> {
                        7155, 8056, 7834,
                        2639, 6601, 8063,
                        2390, 2544, 7022
                    }
                },
                2385,
                573,
                656,
                733,
                1620,
                3626,
                new List<object> {
                    6274,
                    1935,
                    new List<object> { 6481, 928, 8291, 3196, 3431, 6058 },
                    8010,
                    5052,
                    892,
                    3490,
                    2369,
                    951,
                    1606,
                    6763,
                    7260,
                    6122
                }
            },
            5655,
            4223
        };

        List<int> flattenedArray = FlattenArray(nestedArray);

        Console.WriteLine("Flattened Array:");
        foreach (int num in flattenedArray)
        {
            Console.WriteLine(num);
        }
    }
}