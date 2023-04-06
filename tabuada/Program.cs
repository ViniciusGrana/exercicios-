Console.WriteLine($"Insira o número da tabuada que deseja: ");
int tabuada = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Tabuada do {tabuada} x {i} = {tabuada*i}");
    
}

