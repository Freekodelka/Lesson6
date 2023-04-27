/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
int size = 7;

int[] EnterNumbers(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = InPutNum();
    }
    return numbers;
}

int InPutNum()
{
    Console.WriteLine("Enter number: ");
    return int.Parse(Console.ReadLine());
}

int CountPositiveNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] z = EnterNumbers(size);
int y = CountPositiveNumbers(z);
Console.WriteLine("Количество положительных чисел: " + y);

//Console.WriteLine("Количество положительных чисел: " + CountPositiveNumbers(EnterNumbers(size)));
 
 