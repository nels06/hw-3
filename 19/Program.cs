// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool CheckPalindrome(string num)
{
    if(num[0] == num[4] && num[1] == num[3]) return true;
    return false;
}



Console.Write("Введите пятизначное число: ");
string input = Console.ReadLine();

bool isNumber = int.TryParse(input, out int number);

if(isNumber && input.Length == 5)
{
    if(CheckPalindrome(input))
    {
        Console.WriteLine("Да");
        return;
    }
    else
    {
        Console.WriteLine("Нет");
        return;
    }
}
else
{
    Console.WriteLine("Введите, пожалуйста, пятизначное число");
}