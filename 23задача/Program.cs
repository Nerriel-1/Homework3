// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

int Cube (int nLocal)
{
    int res = nLocal * nLocal * nLocal;
    return res;
}
int i = 0;
while (i <= n)
{
    i++;
    Console.WriteLine(Cube(i));
}