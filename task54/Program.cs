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
int[,] DecreasingArray(int[,]array)
{
     bool flag;
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
   // int max=0;
    do {
        flag = false;
  for (int i=0;i<rows;i++)
  {
    for(int j=1;j<cols;j++)
    if(array[i,j-1]<array[i,j])
    {
        int temp = array[i,j-1];
        array[i,j-1] = array[i,j];
        array[i,j]= temp;
        flag=true;
    }
    
  }
    }
    while(flag);
  return array;
  }

int[,] arr = GetRandom2DArray(4,4,0,10);
Print2DArray(arr);
int[,] arr2 = DecreasingArray(arr);
Print2DArray(arr2);
