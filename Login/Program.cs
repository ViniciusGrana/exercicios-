Console.WriteLine($"Digite o usuário: ");
string usuario = Console.ReadLine();
Console.WriteLine($"Digite sua senha: ");
string senha = Console.ReadLine();


while (usuario == senha)
{
    Console.WriteLine($"Senha incorreta ");
    senha = Console.ReadLine();
    
}
 Console.WriteLine($"Bem vindo!");
 



