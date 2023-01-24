/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int InputNumber() 
{
    
    Console.WriteLine("Введите число: ");
    
    int inputNumber;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out inputNumber))
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы должны ввести число! Попробуйте снова: ");
        }
    }

    return inputNumber;
}

int GetThirdDigit(int number)
{
    int thirdDigit = 0;
    if (number > 999)
    {
        while (number > 999) 
        {
            number /= 10;
        }
    }  

    thirdDigit = number % 10;
     return thirdDigit;
}

int number = InputNumber();

if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        int thirdDigit = GetThirdDigit(number);
        Console.WriteLine($"Третья цифра числа {number} это {thirdDigit}");
    }

