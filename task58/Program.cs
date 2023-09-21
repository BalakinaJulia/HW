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
int[,] GetRandom2DArrayAB(int rowNumber, int colNumber, int min, int max)
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
//  int[,] Fill2DArrayB(int rows)
// {
//     Console.Write("Введите кол-во столбцов массива B: ");
//     int cols = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, cols];
//     Console.Write("Введите минимальное значение массива B: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение массива B: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

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
 
int[,] MultTwoMatrix(int[,]MatrixForArray, int[,]MatrixForArrayAB)
{
    int rows = MatrixForArray.GetLength(0);
    int cols = MatrixForArray.GetLength(1);
    int rowsA = MatrixForArrayAB.GetLength(0);
    int colsB = MatrixForArrayAB.GetLength(1);
    int[,] result = new int[rowsA,colsB];
    int count =1;
   // int countAB=1;
  for (int i=0;i<rows;i++)
  {
    // for(int m=0;m<colsB;m++)
    // {
          for(int j=0;j<cols;j++)
          { 
             for(int n=0;n<rowsA;n++)
             { 
               count = MatrixForArray[i,j]*MatrixForArrayAB[j,n];
               // countAB = MatrixForArray[1,j]*MatrixForArrayAB[1,m];
               result[i,n] += count;
             }
          }
    // }
  }
    
  
 // System.Console.WriteLine(sum);
  return result;
  
}
 
int[,] arrA = GetRandom2DArray(2,2,0,3);
int[,] arrB = GetRandom2DArrayAB(2,2,0,3);
Print2DArray(arrA);
Print2DArray(arrB);
int[,] arr2 = MultTwoMatrix(arrA,arrB);
Print2DArray(arr2);
 //MinSum(arr2);
