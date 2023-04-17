
Console.Write($"Digite sua idade ");
float idade = float.Parse(Console.ReadLine());
float meses = idade * 12;
float dias = idade * 365;
float horas = dias * 24;
float minutos = ((24*60) * dias); 



Console.WriteLine($"Sua idade em meses: {meses}");
Console.WriteLine($"Sua idade em dias: {dias}");
Console.WriteLine($"Sua idade em horas: {horas}");
Console.WriteLine($"Sua idade em minutos: {minutos}");


