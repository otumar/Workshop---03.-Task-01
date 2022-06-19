// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом

int Prompt(string massage)
{
    System.Console.Write(massage);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int number = Prompt("Введите пятизначное число: ");
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}
int[] array = new int[5];
array[0] = number / 10000;
array[1] = number % 10000 / 1000;
array[3] = number % 100 / 10;
array[4] = number % 10;
if (array[0] == array[4] && array[1] == array[3]) Console.WriteLine("Введенное число явяется палиндромом");
else
{
    Console.WriteLine("Введенное число не явяется палиндромом");
}
