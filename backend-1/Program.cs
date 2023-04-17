// //entrada
// string nome = "Vinicius";
// int idade = 17;
// float peso = 70;
// float altura = 1.85F;

// //processamento
// float imc = peso / (altura * altura);

// //saida
// Console.WriteLine($"O IMC do " + nome + " é de : " + Math.Round(imc,2));
Console.BackgroundColor = ConsoleColor.DarkCyan
Console.WriteLine(@$"
---------------------
|   programa para   |
|    calcular imc   |
---------------------
");
Console.ResetColor();


Console.Write($"Digite o nome do paciente:");
string nome = Console.ReadLine();

Console.WriteLine($"Informe o peso do paciente");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a altura do paciente");
float altura = float.Parse (Console.ReadLine());

float imc = (peso / ((float)Math.Pow (altura,2)));

Console.WriteLine($"O paciente {nome} + tem imc igual a : {imc}");
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine($"Obrigado por utilizar nosso sistema !");
Console.ResetColor();




