// Тесты:

// for (int i = 1, j = 1; i < 10; i++, j++)
//     Console.WriteLine($"{i * j}");


//     int i = -1;
// do
// {
//     Console.WriteLine(i);
//     i--;
// }
// while (i > 0);


// Таблица умножения:

// for (int i = 1; i < 10; i++)
// {
//     for (int j = 1; j < 10; j++)
//     {
//         Console.Write($"{i * j} \t");
//     }
//     Console.WriteLine();
// }


// Bootcamp3. Big O Notation
// Таблица умножения

int n = Convert.ToInt32(Console.ReadLine());
int [ , ] matrix = new int [n, n];

for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j]);
        Console.Write("   ");
    }
    Console.WriteLine();
}