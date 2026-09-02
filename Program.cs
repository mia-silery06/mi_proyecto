System.Console.WriteLine("ingreso de notas de curso");
int x = 1;
while (x == 1)
{
    for (int i = 1; i < 4; i++)
    {
        System.Console.WriteLine($"ingrese nota  {i} :");
        int nota = int.Parse(Console.ReadLine()!);

    }

    System.Console.WriteLine("Necesita ingresar nuevo estudiante? (s/n)");
    char estudiante = char.Parse(Console.ReadLine()!);
    if (estudiante == 's') x = 1;
    else x = 2;

}