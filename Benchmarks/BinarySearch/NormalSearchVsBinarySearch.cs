using BenchmarkDotNet.Attributes;
using System.Security.Cryptography;

namespace BinarySearch;

public class NormalSearchVsBinarySearch
{
    public List<string> data;

    public NormalSearchVsBinarySearch()
    {
        // Generate dummy string data
        data = GenerateData(100000);

        // Sort the data for binary search
        data.Sort();
    }

    [Benchmark]
    public int NormalSearch() => LinearSearch(data, "100000");

    [Benchmark]
    public int BinarySearch() => BinarySearch(data,"100000");


    // Generate dummy string data
    static List<string> GenerateData(int count)
    {
        List<string> data = new List<string>();
        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            data.Add($"string{i}");
        }
        return data;
    }

    // Linear search
    static int LinearSearch(List<string> data, string target)
    {
        for (int i = 0; i < data.Count; i++)
        {
            if (data[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    // Binary search
    static int BinarySearch(List<string> data, string target)
    {
        int min = 0;
        int max = data.Count - 1;

        while (min <= max)
        {
            int mid = (min + max) / 2;
            int comparisonResult = string.Compare(data[mid], target);

            if (comparisonResult == 0)
            {
                return mid;
            }
            else if (comparisonResult < 0)
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }

        return -1;
    }
}
