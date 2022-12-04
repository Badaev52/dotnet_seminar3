
Console.WriteLine("Введите координаты точки A: ");
int Ax = inputInt("Ax");
int Ay = inputInt("Ay");
int Az = inputInt("Az");
Console.WriteLine("Введите координаты точки B: ");
int Bx = inputInt("Bx");
int By = inputInt("By");
int Bz = inputInt("Bz");

Console.WriteLine("Расстояние между точками равно: " + distanceBetweenPoints(Ax, Ay, Az, Bx, By, Bz));

int inputInt(string name)
{
    Console.WriteLine("Введите число " + name + ": ");
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

double distanceBetweenPoints(int Ax, int Ay, int Az, int Bx, int By, int Bz){
    double res;

    res = Math.Pow((Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2) + Math.Pow((Bz - Az), 2)), 0.5);

    return res;

}