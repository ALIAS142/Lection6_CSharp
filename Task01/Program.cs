// See https://aka.ms/new-console-template for more information

// Random r = New Random();

// Console.CursorVisible = false;
// while(true)
// {
//     Console.SetCursorPosition(
//         left: r.Next(Console.WindowWidth),
//         top: r.Next(Console.WindowHeight)

//     );
//     Console.Write(r.Next(10));
//     Thread.Sleep(1000);
// }

Console.Write("Введите имя: ");
string name = Console.ReadLine();
 
Console.Write("Введите возраст: ");
int age = Convert.ToInt32(Console.ReadLine());
 
Console.Write("Введите рост: ");
double height = Convert.ToDouble(Console.ReadLine());
 
Console.Write("Введите размер зарплаты: ");
decimal salary = Convert.ToDecimal(Console.ReadLine());
 
Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м  Зарплата: {salary}$");