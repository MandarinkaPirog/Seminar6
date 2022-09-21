//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

int n= Prompt("Введите число элементов массива");
int[] array= new int[n];
fullArray(array);
printArray(array);
int Prompt( string message)
{
System.Console.WriteLine(message);
return Int32.Parse(Console.ReadLine());
}
void fullArray(int[] array)
{
    for(int i=0; i<array.Length;i++)
{
    array[i]= Prompt("Введите число ");
}
}
void printArray(int[] array)
{
    int count=0;
    for(int i=0; i< array.Length;i++)
    {
        if(array[i]>0)
        count++;
    }
    System.Console.WriteLine("Из введенных чисел больше нуля: "+ count);
}