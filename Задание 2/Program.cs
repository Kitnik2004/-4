string operand_1, operand_2;
Console.WriteLine("Введите 1 число, с которым вы хотите провести операцию");
operand_1=Console.ReadLine();
Console.WriteLine("Введите какое действие совершить над числами ");
string operation = Console.ReadLine();
Console.WriteLine("Введите 2 число, с которым вы хотите провести операцию");
operand_2=Console.ReadLine();
float result = 0;
try                                                 //Проверка на ошибки
{
    int operand_11 = Convert.ToInt32(operand_1);    //Перевод из строки в число
    int operand_22 = Convert.ToInt32(operand_2);
    switch (operation)
    {
        case "+":
            {
                result = operand_11 + operand_22;
                Console.WriteLine("Результат выражения: {0} {1} {2} = {3}", operand_11, operation, operand_22, result);
                break;
            }
        case "-":
            {
                result = operand_11 - operand_22;
                Console.WriteLine("Результат выражения: {0} {1} {2} = {3}", operand_11, operation, operand_22, result);
                break;
            }
        case "*":
            {
                result = operand_11 * operand_22;
                Console.WriteLine("Результат выражения: {0} {1} {2} = {3}", operand_11, operation, operand_22, result);
                break;
            }
        case "/":
            {
                if (operand_22 != 0)                //Проверка деления на ноль
                    result = operand_11 / operand_22;
                else

                    Console.WriteLine("Невозможно разделить на ноль");

                break;
            }
    }
}
catch                                               //В случае ошибки будет выведено сообщение
{
    Console.WriteLine("Вы допустили ошибку");
}