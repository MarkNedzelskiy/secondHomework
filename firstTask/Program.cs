/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int InputThreeDigitNumber() 
{
    
    Console.WriteLine("Введите трехзначное число: ");
    
    int inputNumber;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out inputNumber))
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы должны ввести трехзначное число! Попробуйте снова: ");
        }
    }

    return inputNumber;
}

int FindSecondDigit(int number) {
    
    int secondDigit = (number % 100) / 10;

    return secondDigit;
}

int number = InputThreeDigitNumber();
int secondDigit = FindSecondDigit(number);

Console.WriteLine($"Вторая цифра в числе {number} это {secondDigit}");