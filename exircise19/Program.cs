// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num1 = inputInt();

int inputInt()
{
    Console.WriteLine("Введите число: ");
    bool isInt = int.TryParse(Console.ReadLine(), out int num);
    if (isInt)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное число!");
        return -1;
    }

}

int count = 0;
int temp = num1;
bool isNegative = false;

if (num1 == 0)
{
    Console.WriteLine("Введенное число равно нулю...");
}
else if (num1 == 1)
{
    Console.WriteLine("Введенное число равно 1, является полиндромом");
}
else if (num1 == -1)
{
    Console.WriteLine("Введенное число равно -1, является полиндромом");
}
else if (num1 < 0)
{
    num1 = num1 * -1;
    isNegative = true;
}

while (temp > 0)
{
    temp = temp / 10;

    count++;
}