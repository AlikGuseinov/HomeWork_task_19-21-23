// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*

Console.WriteLine("Задача №23");
Console.Write("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

for (int b = 0; b <= a; b++)
{

    int c =b*b*b;

    Console.WriteLine(c);      
}
*/

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*

Console.WriteLine("Задача №19");

Console.Write("Введите пятизначное число: ");

int a = Convert.ToInt32(Console.ReadLine());

string number = Convert.ToString(a);



    if (number[0]==number[4] || number[1]==number[3])

    {

        Console.WriteLine($"Число: {a} является пилндромом");

    }

    else

    {

        Console.WriteLine($"Число: {a} не является палиндромом");

    }



if (number.Length > 5 && number.Length < 5)

{

    Console.WriteLine("Вы ввели не верное число для проверки на полиндром");

}
*/

// Задача №21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
Console.WriteLine("Задача №21");
Console.Write("Введите координату (X) первой точки: ");

double x1 = Convert.ToDouble(Console.ReadLine());



Console.Write("Введите координату (У) первой точки: ");

double y1 = Convert.ToDouble(Console.ReadLine());



Console.Write("Введите координату (Z) первой точки: ");

double z1 = Convert.ToDouble(Console.ReadLine());



Console.WriteLine();

Console.WriteLine();



Console.Write("Введите координату (X) второй точки: ");

double x2 = Convert.ToDouble(Console.ReadLine());



Console.Write("Введите координату (У) второй точки: ");

double y2 = Convert.ToDouble(Console.ReadLine());



Console.Write("Введите координату (Z) второй точки: ");

double z2 = Convert.ToDouble(Console.ReadLine());





 double Final = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1)*(y2 - y1)) + ((z2 - z1)*(z2 - z1)));



 Console.WriteLine("Расстояние между введенными координатами: "+Final);
 */