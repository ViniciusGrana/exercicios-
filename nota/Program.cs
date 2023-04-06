Console.WriteLine($"Digite uma nota de 0 a 10");
float nota = float.Parse(Console.ReadLine());


while (nota < 0 || nota> 10)
{
    Console.WriteLine($"Nota invalida");
    nota = float.Parse(Console.ReadLine());
}
Console.WriteLine($"Nota valida");



