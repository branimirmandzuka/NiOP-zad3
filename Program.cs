int x = int.Parse(Console.ReadLine() ?? string.Empty);
int y = int.Parse(Console.ReadLine() ?? string.Empty);
int z = int.Parse(Console.ReadLine() ?? string.Empty);

if ( x == 0 || y == 0 || z == 0 )
{
    Console.WriteLine("Neispravan unos");
    return;
}

if ( x != Math.Sqrt(y*y + z*z) && y != Math.Sqrt(x*x + z*z) && z != Math.Sqrt(x*x + y*y))
{
    Console.WriteLine("Trokut nije pravokutan.");
}
else
{
    Console.WriteLine("Trokut je pravokutan.");
}