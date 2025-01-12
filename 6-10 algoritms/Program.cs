#region task1
//for (int i = 1; i < 100; i++)
//{
//    if (i % 2 == 1)
//    {
//        Console.WriteLine(i);
//    }
//}
#endregion
#region task2
//int sum = 0;
//for (int i = 1; i <= 888; i++)
//{
//    if(i>0 && i <= 888)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);
#endregion
#region task3
//Console.WriteLine("Regem daxil edin:");
//int num=int.Parse(Console.ReadLine());
//int sum = 0;
//  while (num > 0)
//  {
//    int t = num % 10;
//    num /= 10 ;
//    sum += t;
//  }
//Console.WriteLine(sum);
#endregion
#region task5
int num =int.Parse(Console.ReadLine());
for (int i = 1; i <= 1000; i++)
{
    double kok=Math.Sqrt(i);
    int tamKok = (int)kok;  

    if (tamKok == kok)
    Console.WriteLine(i);
}
#endregion