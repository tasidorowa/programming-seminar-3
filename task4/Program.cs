// Дано натуральное трехзначное число. Создать массив из цифр этого числа. Младший разряд на первом месте в массиве

int num = 648;
int[] array = new int[3];

for (int i = 0; i < array.Length; i++)
{
    array[i] = num % 10;
    num /= 10;
    Console.Write($"{array[i]} ");
}
