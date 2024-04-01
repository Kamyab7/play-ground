using BenchmarkDotNet.Running;
using BinarySearch;

var summary = BenchmarkRunner.Run<NormalSearchVsBinarySearch>();

Console.ReadKey();