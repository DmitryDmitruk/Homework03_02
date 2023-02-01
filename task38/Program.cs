// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


Console.Clear();

double randomDouble(int minDouble, int maxDouble)   //генерируем  случайные дробные числа
{
      double randomNumbers=new  Random().NextDouble()*(maxDouble-minDouble)*maxDouble;
      return randomNumbers;
}
double[] RandomArray(int size, int minDouble, int maxDouble)
{
         double[]array= new double [size];
         for (int i = 0; i < size; i++)
         {
            array[i] = randomDouble( minDouble,maxDouble );
         }
         return array;
         
}


double max(double[]array)
{   int count= array.Length;
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

double min(double[]array)
{   int count= array.Length;
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
double[]res=RandomArray(6,-5,10);
Console.WriteLine(String.Join(" ", res));
double result=max(res)-min(res);
Console.WriteLine($"Ответ {result}");
