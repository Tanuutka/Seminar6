// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.WriteLine("Введите элементы массива через пробел: ");
string numbers = Console.ReadLine();
int[] myArray = GetArrayFromString(numbers);
resultArray(myArray);

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
}

void resultArray(int[] array)
{
    int sumpos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumpos++;
    }
    Console.WriteLine("Количество положительных чисел равно " + sumpos);
}

