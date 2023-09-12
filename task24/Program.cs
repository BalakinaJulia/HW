
Console.WriteLine("Введите число");
int numberUser = Convert.ToInt32(Console.ReadLine());

int sumOfNumber(int number)
{
    int sum = 0;
    for(int i = 1; i<= numberUser; i++)
    {
        sum +=i;
    }
    return sum;
}
Console.WriteLine($"Сумма цифр в числе {numberUser} равна {sumOfNumber(numberUser)}");