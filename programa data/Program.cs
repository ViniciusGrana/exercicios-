Console.WriteLine($"Qual o dia do seu aniversario? ");
float dia = float.Parse(Console.ReadLine());
Console.WriteLine($"Qual o mes do seu aniversario? ");
float mes = float.Parse(Console.ReadLine());
Console.WriteLine($"Qual o ano do seu aniversario? ");
float ano = float.Parse(Console.ReadLine());

if (dia <= 31 && mes<=12 && ano<=2013)
{
    Console.WriteLine($"Data valida");
    
}
else{
    Console.WriteLine($"Data invalida");
    
}
