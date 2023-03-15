//Напишите программу, которая принимает на вход
//пятизначное число и проверяет, является ли 
//оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int i = number.Length;

if (i == 5)
{
    if (number[0]==number[4] && number[1]==number[3])
    {
        Console.WriteLine("Данное число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Данное число не является полиндромом.");
    }
}
else
{
    Console.WriteLine("Число не является пятизначным, попробуйте ещё раз.");
}

//Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние 
//между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/Console.WriteLine("Введите X точки В");
int XB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y точки В");
int YB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите X точки A");
int XA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y точки A");
int YA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите X точки Z");
int XZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y точки Z");
int YZ = Convert.ToInt32(Console.ReadLine());

double number =Math.Sqrt((Math.Pow((XB-XA),2))+(Math.Pow((YB-YA),2))+(Math.Pow((XZ-YZ),2)));

Console.Write(number);



//Напишите программу, которая принимает на вход 
//число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int count =1;

while (count<=num)
{
  Console.Write(Math.Pow(count,3) +" ");
  ++count;  
} 