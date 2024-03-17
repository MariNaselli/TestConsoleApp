// See https://aka.ms/new-console-template for more information
using ArrayManagement;
using System;

//Console.WriteLine("Probando Array..");

int[] array = [9, 4, 5, 8, 2, 6];
int fromIndex = 0;
int toIndex = 5;
int result = ArraySorter.FindIndexOfMin(array, fromIndex, toIndex);
Console.WriteLine("result: " + result);

ArraySorter.SwapElements(array, 0, 4);

ArraySorter.SortArray(array);



