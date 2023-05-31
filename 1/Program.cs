// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// // 0, 7, 8, -2, -2 -> 2

// // 1, -7, 567, 89, 223-> 3






Console.WriteLine("Введите количество элементов");

int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int [size];

int count = 0;

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"{i + 1} число");

    array[i] = Convert.ToInt32(Console.ReadLine());

    if(array[i] > 0)
    {
        count++;
    }

}
Console.WriteLine($" {count} чисел больше 0  ");