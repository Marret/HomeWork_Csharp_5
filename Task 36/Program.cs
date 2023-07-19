/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


Console.Clear();
int[] startArray = GetArray(4, -10, 10);
Console.WriteLine(String.Join(" ", startArray ));
Console.WriteLine($"Сумма элементов в нечетном индексе = {GetCount(startArray )}  ");

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
    int sum = 0; 
   for (int i=0; i<arr.Length; i++ )
   {
     
    if (i%2 == 1)
    {
       sum+=arr[i];
    }
   }
     return  sum;
}
