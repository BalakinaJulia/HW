double[,] GetRandom2DArray(int rowNumber, int colNumber, int maxValue, int minValue)
{
    double[,] result = new double[rowNumber,colNumber];
    for(int i=0; i< rowNumber;i++)
    {
         for(int j=0; j< colNumber;j++)
         {
          result[i,j]= new Random().NextDouble()*(maxValue-minValue)+minValue;
         }
    }
    return result;
}

void Print2DArray(double[,] arrayToPrint)
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
                System.Console.Write(Math.Round(arrayToPrint[i,j],3)+ "\t");
            } 
             System.Console.WriteLine();
             System.Console.WriteLine();
        } 
}

double[,] randomArray = GetRandom2DArray(5,5,-10,10);
Print2DArray(randomArray);