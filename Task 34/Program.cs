﻿/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Clear();
int[] startArray = GetArray(10, 100, 999);
Console.WriteLine(String.Join(" ", startArray ));
Console.WriteLine($"Количество четных элементов в массиве = {GetCount( startArray )}  ");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


int GetCount(int[] arr)
{
    int count = 0; 
   foreach (int item in arr)
   {
    if (item%2 == 0)
    {
       count++; 
    }
   }
     return  count;
}