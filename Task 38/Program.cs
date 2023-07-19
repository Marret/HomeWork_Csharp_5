/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/
Console.Clear();
Console.WriteLine("Массив [3.22, 4.2, 1.15, 77.15, 65.2]");
double[] Array = {3.22, 4.2, 1.15, 77.15, 65.2};

double raz(double[] Array)
{
double min = Array[0];
double max = Array[0];
int i = 1;
while (i < Array.Length)
{
if (max<Array[i])
max = Array[i];
if (min>Array[i])
min = Array[i];
i = i + 1;
}
return max-min;
}


Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {raz(Array):F2}");