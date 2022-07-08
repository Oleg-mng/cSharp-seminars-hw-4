//Задача 27: 
//Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine(" Введите любое целое число до 10-ти символов,");
Console.WriteLine("и программа выдаст сумму цифр в данном числе:");
int Num = Convert.ToInt32(Console.ReadLine());
int SumOfnumber(int Num)
{
    int sum = 0;
    int m = Num;
        for (int i = 0; i <= 10; i++)
        {
         sum = sum + (m % 10);
         m = m / 10;
        }

    return (sum);
}
int s = SumOfnumber(Num);
Console.WriteLine(s);