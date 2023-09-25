 //Первый больше похож на вариант из семинара, но там не выводилась последняя цифра, поэтому я исправила, на всякий скину 2 варианта

int SumNaturalNum1(int n, int m)
{
   if(n==m) return m ;
   else if(n>=m) return 1;

   else 
    System.Console.Write(n+" ");
      return  n + SumNaturalNum1(n+1,m);
   
}
 
int result1 = SumNaturalNum1(1,5);
 System.Console.Write(result1);
System.Console.WriteLine(" ");
 int SumNaturalNum(int n, int m)
{
    if(n<=m) {
    System.Console.Write(n+" ");
      return  n + SumNaturalNum(n+1,m);
    }
   else return 0 ;
   //else if(n>=m) return 1;

    
   
}
int result = SumNaturalNum(1,5);
 System.Console.Write(result);