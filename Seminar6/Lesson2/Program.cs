//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.WriteLine("Найти точку пересечения прямых заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите k1,b1 через пробел: ");
string numbers1 = Console.ReadLine();
int[] myArray1 = GetArrayFromString(numbers1);
Console.WriteLine("Введите k2,b2 через пробел: ");
string numbers2 = Console.ReadLine();
int[] myArray2 = GetArrayFromString(numbers2);

double b1 = Convert.ToInt32(myArray1[1]);
double k1 = Convert.ToInt32(myArray1[0]);
double b2 = Convert.ToInt32(myArray2[1]);
double k2 = Convert.ToInt32(myArray2[0]);

if (k1 == k2) Console.Write("Прямые не пересекаются, введите друе значения k1 и k2!");

else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Write($"Точка пересечения двух прямых:  {(x, y)}");
}

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

