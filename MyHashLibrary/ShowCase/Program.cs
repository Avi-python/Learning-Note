// See https://aka.ms/new-console-template for more information
using MyHashLibrary.Component;

LinearProbingTable a = new LinearProbingTable(10);
int[] arr = new int[]{90, 19, 100, 50, 40, 32, 234, 555, 23, 20};
a.StartHash(arr, HashFunction.DivisionHash);
a.ShowTable();

