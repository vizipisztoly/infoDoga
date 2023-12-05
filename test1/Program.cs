Console.WriteLine("\t\nHúrtrapéz cucók");
int a;
int c;
int m;
do
{
    Console.Write("\n\nA húrtrapéz 'a' oldala:");
    a = int.Parse(Console.ReadLine());
    if (a > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Helytelen adat!");
    }
} while (a < 0);
do
{
    Console.Write("\n\nA húrtrapéz 'c' oldala:");
    c = int.Parse(Console.ReadLine());
    if (c > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Helytelen adat!");
    }
} while (c < 0);
do
{
    Console.Write("\n\nA húrtrapéz magassága:");
    m = int.Parse(Console.ReadLine());
    if (m > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Helytelen adat!");
    }
} while (m < 0);
//double b = (m * m + ((a - c) / 2) * ((a - c) / 2));
double b = Math.Pow(m, 2) + Math.Pow((a - c) / 2, 2);
double kerulet = a + 2 * b + c;
double terulet = (a + c) / 2 * m;
double ar = Math.Asin(m/b);
double af = ar * (180/Math.PI);
Console.WriteLine($"'b' oldala: {b}");
Console.WriteLine($"Területe: {terulet}");
Console.WriteLine($"Kerülete: {kerulet}");
Console.WriteLine($"Alfa szöge: {af}");
Console.ReadKey();