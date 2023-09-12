
int[] GetRandomArray()
{
  int[] array = new int[8];
  for(int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100,999);
  }
  return array;
}

  
int NumberOfEveninTheArray(int[] arrayCount)
{
    int count=0;
    for(int i = 0;i<arrayCount.Length;i++)
    {
    
        if(arrayCount[i]%2==0)
        {
           count++;

        }
    }
    System.Console.WriteLine(count);
    return count;
      
 
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
NumberOfEveninTheArray(userArray);
