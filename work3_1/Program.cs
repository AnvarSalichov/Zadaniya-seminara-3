// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine ("Введите пятизначное число");
// int num = Convert.ToInt32 (Console.ReadLine());
// string number = Console.ReadLine();
// if ((num>9999)&&(num<1000000))
// {
//     if (number[0]==number[4]&&number[1]==number[3])
//     Console.WriteLine ("Данное пятизначное число - это палиндром");
//     else
//     Console.WriteLine ("Данное пятизначное число не является палиндромом");
// }   
// else
// {
// Console.WriteLine ("Введено неверное число");    
// }

Console.WriteLine ("Введите пятизначное число");
string number = Console.ReadLine();
int num=number.Length;
if (num==5)
    if (number[0]==number[4]&&number[1]==number[3])
        Console.WriteLine ("Данное пятизначное число - это палиндром");
    else
        Console.WriteLine ("Это не палиндром");
else 
    Console.WriteLine("Введено не пятизначное число");
