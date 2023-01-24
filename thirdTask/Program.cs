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
    if (day == 1)
    {
        Console.WriteLine("Понедельник");
    }
    else if (day == 2)
    {
        Console.WriteLine("Вторник");
    }
    else if (day == 3)
    {
        Console.WriteLine("Среда");
    }
    else if (day == 4)
    {
        Console.WriteLine("Четверг");
    }
    else if (day == 5)
    {
        Console.WriteLine("Пятница");
    }
    else if (day == 6)
    {
        Console.WriteLine("Суббота - это выходной!");
    }
    else if (day == 7)
    {
        Console.WriteLine("Воскресенье - это выходной!");
    }
    
}

int dayNumber = InputDayNumber();
ShowDayOfTheWeek(dayNumber);
