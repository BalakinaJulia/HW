double[] GetRandomArray()
{
  double[] array = new double[8];
  double buffer;
  for(int i = 0; i < array.Length; i++)
  {
    buffer=new  Random().Next(-990,990);
    array[i] = buffer/10 ;
  }
  return array;
}
void PrintArray(double[] arrayToPrint)
{
    
    for(int i = 0; i<arrayToPrint.Length;i++)
    {
        
        System.Console.WriteLine($"{arrayToPrint[i]}");
    }
}

double TheDifferenceBetweenMaxAndMin(double[] array)
{
    double result=0;
    double max = -100;
    for(int i=0; i<array.Length;i++)
    {
        if(array[i]>max)
        max=array[i];
    }
    System.Console.WriteLine();
    System.Console.WriteLine(max);
   // return max;
    double min = 100;
    for(int i=0; i<array.Length;i++)
    {
        if(array[i]<min)
        min=array[i];
    }
    System.Console.WriteLine();
    System.Console.WriteLine(min);
   // return min;
     result=max-min;
    System.Console.WriteLine();
    System.Console.WriteLine(result);
    return result;
}
double[] userArray = GetRandomArray();
PrintArray(userArray);
TheDifferenceBetweenMaxAndMin(userArray);