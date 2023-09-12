int[] GetRandomArray()
{
  int[] array = new int[8];
  for(int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-99,99);
  }
  return array;
}
int SumOfEleminTheArray(int[] arraySum)
{
    int sum=0;
    for(int i = 0;i<arraySum.Length;i++)
    {
    
        if(i%2==1)
        {
           sum+=arraySum[i];

        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine(sum);
    return sum;
      
}
void PrintArray(int[] arrayToPrint)
{
    
    for(int i = 0; i<arrayToPrint.Length;i++)
    {
        
        System.Console.WriteLine($"{arrayToPrint[i]}");
    }
}
int[] userArray = GetRandomArray();
PrintArray(userArray);
SumOfEleminTheArray(userArray);