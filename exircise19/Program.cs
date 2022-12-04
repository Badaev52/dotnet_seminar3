// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// -12321 -> не является полиндромом, т.к. -12321 != 12321
// max int 2,147,483,647

int num = inputInt();
//Console.WriteLine("Количество разрядов числа: " + numberOfDigits(num));
Console.WriteLine();
int res = numIsPalindrome(num);
printResult(res);

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

/** Функция возвращает:
    0 - Число меньше нуля - не палиндром -121 != 121-
    1 - Число просто не палиндром
    2 - Число является палиндромом
*/
int numIsPalindrome(int num)
{
    int result;
    if (num < 0)
    {
        result = 0;
    }
    else
    {
        int digit = numberOfDigits(num);
        int[] numRev = new int[digit];

        int count = 0;
        int temp = num;
        while (count < digit)
        {
            numRev[count] = temp % 10;
            temp = temp / 10;
            count++;
        }
        String str = String.Empty;
        // Обратное число в виде строки
        for (int i = 0; i < digit; i++)
        {
            str = str + numRev[i];
        }
        // Переводим строку в число
        int.TryParse(str, out int num1);
        // Определяем палиндром да/нет
        if (num == num1)
        {
            result = 2;
        }
        else
        {
            result = 1;
        }

    }

    return result;

}

int numberOfDigits(int number)
{
    int digits = 0;
    if (number == 0) return 1;
    while (number > 0)
    {
        number = number / 10;
        digits++;
    }
    return digits;
}

void printResult(int num)
{
    if (num == 0) Console.WriteLine("Введенное число меньше 0 и не является палиндромом");
    else if (num == 1) Console.WriteLine("Заданное число не является палиндромом");
    else Console.WriteLine("Заданное число является палиндромом");
}