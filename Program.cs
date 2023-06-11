// void CheckEven (int num1, int num2)
// {
//     if(num1 % 2 == 0)
//     {
//         System.Console.WriteLine($"число {num2} кратно {num1}");
//     }
//     else
//     {
//         System.Console.WriteLine($"число {num2} не кратно {num1} остаток от деления -> {num1 % num2}");
//     }
// }

// System.Console.WriteLine("Введите первое число ->");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число ->");
// int num2 = Convert.ToInt32(Console.ReadLine());

// CheckEven (num1, num2)

bool CheckEven (int num)
{
    if (num % 7 == 0 && num % 23 == 0) 
    return true;
else
    return false;


}
System.Console.Write("Введите число ->");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CheckEven(num1, num2));