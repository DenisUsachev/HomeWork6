/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


Console.Write("Сколько количество чисел в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int [number];

    
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"Введите {i} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        count++;
    }
}


Console.WriteLine($"Количество положительных чисел является: {count}");