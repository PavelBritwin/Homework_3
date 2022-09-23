// Task 19
Console.Clear();
Console.WriteLine("Введите число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
string inputNumberStr = inputNumber.ToString();
if (inputNumberStr[0] == inputNumberStr[4])
{
    if (inputNumberStr[1] == inputNumberStr[3]) Console.WriteLine("да");
    else Console.WriteLine("нет");
}
else Console.WriteLine("нет");