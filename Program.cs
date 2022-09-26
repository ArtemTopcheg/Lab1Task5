//Задача 5

int Nmax = 1000;
int sum = 0;
for (int i = 1; i < Nmax; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        sum += i;
    }
}
Console.WriteLine(sum);