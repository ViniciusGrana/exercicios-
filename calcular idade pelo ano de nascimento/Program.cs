int anoNascimento;
int idade;
int idadeEmSemanas;
int anoAtual = DateTime.Now.Year;

Console.WriteLine($"Informe seu ano de nascimento: ");
anoNascimento = int.Parse(Console.ReadLine());

idade = (anoAtual - anoNascimento);
idadeEmSemanas = (idade * 52);

Console.WriteLine($"A idade em ano(s) é {idade} ano(s) e a idade em semanas é {idadeEmSemanas} semanas");


