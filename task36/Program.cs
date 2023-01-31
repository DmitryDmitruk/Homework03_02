//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();

int[]GetArray(int size, int minValue, int maxValue)
{
      int[]res = new int [size];
      for (int i = 0; i < size; i++)
      {
        res[i]= new Random().Next(minValue,maxValue);
      }
      return res;

} 
int[]array=GetArray(3,0,50);
Console.WriteLine(String.Join(" ", array)); 

int sumNumber(int[]array)
{
    int count =array.Length;
    int sum =0;
     for (int i = 0; i < count; i++)
     { 
        if (i%2!=0&&1!=0)
        {
           sum=sum+array[i]; 
        }
        
     }
     return sum;

}
int result=sumNumber(array);
Console.WriteLine($"Сумма элементов равна {result}");