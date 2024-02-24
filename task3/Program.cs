// Найти произведение пар чисел в одномерном массиве (первый и последний, второй и предпоследний), записать
// результат в новый массив

int[] array = [6, 7, 10, -7, 8, -8, 5, -2, 4];
int[] array2 = new int[array.Length / 2]; // array.Length / 2 + 1] если нужно вывести элемент, для которого нет пары

for (int i = 0; i < array.Length / 2; i++)
{
    array2[i] = array[i] * array[array.Length - 1 - i];
    Console.Write($"{array2[i]} ");
}
// if (array.Length % 2 != 0) Console.Write($"{array[array.Length / 2]}");