int num = inputInt();
int[] array = new int[num];

getArrayCubes(array, num);

printArrayConsole(array);


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

void getArrayCubes(int[] arr, int num)
{

    for (int i = 0; i < num; i++)
    {

        arr[i] = (int)Math.Pow(i+1, 3);

    }

}

void printArrayConsole(int[] arr){

    for(int i= 0; i< arr.Length; i++){
        Console.Write(arr[i]);
        if(i < arr.Length - 1) Console.Write(", ");
    }

}