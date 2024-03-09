// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Clear();

void GetSumDigit(int m, int n)
{
   
    if (n == m - 1)
   
    {
        return;
    }
    if (m > n)
    {
         Console.Write( "аргумент m не должен быть больше n ");
         return;
    }

    else
       if( n <0 || m < 0 )

       {
        
         Console.Write( "числа не натуральные ");
         return;
       }

          GetSumDigit (m, n - 1);
          Console.Write(n+" ");
          
            
}
 GetSumDigit (2, 6);


