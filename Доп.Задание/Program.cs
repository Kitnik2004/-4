Console.Write("Введите описание погоды, и я его переведу: ");
string ru = "0";
ru = Console.ReadLine();
switch (ru)
{
    case "Ветренно":
        {
            Console.WriteLine("Windy");
            break;
        }
    case "Ясно":
        {
            Console.WriteLine("Clearly");
            break;
        }
    case "Дождь":
        {
            Console.WriteLine("Rain");
            break;
        }
    case "Снег":
        {
            Console.WriteLine("Snow");
            break;
        }
    case "Облачно":
        {
            Console.WriteLine("Cloudy");
            break;
        }
    case "Гроза":
        {
            Console.WriteLine("Thunderstorm");
            break;
        }
    case "Холод":
        {
            Console.WriteLine("Cold");
            break;
        }
    case "Тепло":
        {
            Console.WriteLine("Heat");
            break;
        }
    case "Жарко":
        {
            Console.WriteLine("Hot");
            break;
        }
    case "Прохладно":
        {
            Console.WriteLine("Chilly");
            break;
        }
    default:
        {
            Console.WriteLine("Такого слова у меня нет, я только учусь");
            break;
        }
}