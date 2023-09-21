int[,] GetRandom2DArray(int rowNumber, int colNumber, int min, int max)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(min, max); ;
        }
    }
    return result;
} 

 void Print2DArray(int[,] arrayToPrint)
{
    System.Console.Write($"[ ]\t");
    for(int i=0; i< arrayToPrint.GetLength(1);i++)
    {
        Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
   for(int i=0; i< arrayToPrint.GetLength(0);i++)
        {
            Console.Write($"[{i}]\t");
             
            for(int j =0; j<arrayToPrint.GetLength(1);j++)
            {
                System.Console.Write(arrayToPrint[i,j]+ "\t");
            } 
             System.Console.WriteLine();
             System.Console.WriteLine();
        } 
}
void PrintArray(int[] arrayToPrint)
{
    
    for(int i = 0; i<arrayToPrint.Length;i++)
    {
        
        System.Console.WriteLine($"{arrayToPrint[i]}");
    }
}
int[] SumArray(int[,]array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[] sum = new int[rows];
  for (int i=0;i<rows;i++)
  {
    for(int j=0;j<cols;j++)
  {
     sum[i]+=array[i,j];
  }
    }
 // System.Console.WriteLine(sum);
  return sum;
  
}
void MinSum (int[] array)
{
    int min= array[0];
    int number= 0;
    for(int i=0; i<array.Length;i++)
    {
     if(array[i]<min)
     {
         min= array[i];
         number = i;
     }  
    } 
    Console.WriteLine($"Наименьшая сумма {min}");
}
int[,] arr = GetRandom2DArray(4,4,0,10);
Print2DArray(arr);
int[] arr2 = SumArray(arr);
PrintArray(arr2);
 MinSum(arr2);
//PrintArray(arr3);
