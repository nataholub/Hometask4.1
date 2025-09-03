Console.WriteLine("Введіть порядковий номер дня тижня");

bool isSuccessful = int.TryParse(Console.ReadLine(), out int dayNum);

if (isSuccessful)
{
    switch (dayNum)
    {
        case 1:
            Console.WriteLine("Понеділок");
            break;
        case 2:
            Console.WriteLine("Вівторок");
            break;
        case 3:
            Console.WriteLine("Середа");
            break;
        case 4:
            Console.WriteLine("Четвер");
            break;
        case 5:
            Console.WriteLine("П'ятниця");
            break;
        case 6:
            Console.WriteLine("Субота");
            break;
        case 7:
            Console.WriteLine("Неділя");
            break;
        default:
            Console.WriteLine("Не існує дня тижня з таким порядковим номером");
            break;
    }
}
else
    Console.WriteLine("Введено некоретне значення");
