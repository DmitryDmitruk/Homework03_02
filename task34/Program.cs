//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();

int[]GetArray(int size, int minValue, int maxValue)
{
     int[]res =new int[size];
     for (int i = 0; i < size; i++)
     {
        res[i]= new Random().Next(minValue, maxValue);
     }
     return res;

} 
int[]array=GetArray(12, 100, 1000);
Console.WriteLine(String.Join(" ", array));

int evenNumbers(int[]array)
{
     int count =array.Length;
     int index =0;

      for (int i = 0; i < count; i++)
      {
         if (array[i]%2==0)
         {
            index+=1 ;
         }
      }
      return index;

}
int result =evenNumbers(array);
Console.WriteLine($"количество четных чисел {result}");