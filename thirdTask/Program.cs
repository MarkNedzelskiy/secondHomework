/*

*/


int InputDayNumber() 
{
    
    Console.WriteLine("Введите число дня недели: ");
    
    int inputNumber;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out inputNumber))
        {
            if (inputNumber < 1 || inputNumber > 7)
            {
                Console.WriteLine("Введите число от 1 до 7: ");
                continue;
            }
            break;
        }
        else
        {
            Console.WriteLine("Вы должны ввести число! Попробуйте снова: ");
        }
    }

    return inputNumber;
}

void ShowDayOfTheWeek(int day)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
    
    
}

int dayNumber = InputDayNumber();
ShowDayOfTheWeek(dayNumber);
