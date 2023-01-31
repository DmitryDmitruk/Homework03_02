// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


Console.Clear();

double GetArray(int size)
{
  double[] array= new double[size];
  Random rnd = new Random();

    for(int j = 0; j < size; j++)
{    
    Console.WriteLine(rnd.NextDouble());
}
return array;
}
double[] res=GetArray(10);
/*
double max()
{   int count= array.length;
    double max= array[0];
     for (int i = 0; i < count; i++)
     {
        if (array[i]>max)
        {
            max=array[i];
        }
     }
     return max;

}

double min()
{   int count= array.length;
    double min= array[0];
     for (int i = 0; i < count; i++)
     {
        if (array[i]<min)
        {
            min=array[i];
        }
     }
     return min;

}
double result=max(array)-min(array);
Console.WriteLine($"Ответ {result}");*/
