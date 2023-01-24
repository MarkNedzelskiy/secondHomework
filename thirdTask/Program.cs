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
            break;
        }
        else
        {
            Console.WriteLine("Вы должны ввести число! Попробуйте снова: ");
        }
    }

    return inputNumber;
}

