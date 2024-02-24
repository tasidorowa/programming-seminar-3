// Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.

int num = 100000;
int num2 = num;
int digitCount = 0;

while (num > 0)
{
    num /= 10;
    digitCount++;
}
//Console.Write(digitCount);

int [] array = new int[digitCount];
for (int i = 0; i < array.Length; i++)
{
    array[array.Length - 1 - i] = num2 % 10;
    num2 /= 10;
}

foreach (int e in array)
{
    Console.Write($"{e} ");
}
