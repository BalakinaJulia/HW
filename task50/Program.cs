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

 int[,] ItemPosition (int x, int y)
 {
    int[,] matrix=GetRandom2DArray(3,3,0,10);

    if((x>=0 && x< matrix.GetLength(0))&&(y>=0 && y< matrix.GetLength(1)) )
    { 
      Console.WriteLine(matrix[x,y]);
    }
    else 
        System.Console.WriteLine("Такого элемента нет");
    return matrix;
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
int[,] randomArray = ItemPosition(4,3);
Print2DArray(randomArray);
