

void NaturalNum(int n)
{
    if(n>=1)
    {
        System.Console.Write(n+" ");
        NaturalNum(n-1);
    }
}

NaturalNum(6);