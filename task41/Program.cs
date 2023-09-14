Console.WriteLine("Введите числа");
int[] FillUserArray()
{
    int[] array = new int[5];
    for(int i=0;i<array.Length;i++)
    {
       array[i]= Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int NumberOfOverZiroinTheArray(int[] arrayCount)
{
    int count=0;
    for(int i = 0;i<arrayCount.Length;i++)
    {
    
        if(arrayCount[i]>0)
        {
           count++;

        }
    }
   // System.Console.WriteLine(count);
    return count;
}
int[] userArray = FillUserArray();
int result = NumberOfOverZiroinTheArray(userArray);
Console.WriteLine();
Console.Write(result);
//NumberOfOverZiroinTheArray(userArray);