char sexo;
char gostouDoProduto;

int totalSim = 0;
int totalNao = 0;

int totalMulherSim = 0;
int totalHomemNao = 0;

int totalMulher = 0;
int totalHomem = 0;

double porcentagemHomemNao = 0;



for (var i = 1; i <= 3; i++)
{

    Console.WriteLine(@$"
Informe seu sexo:
'm' para masculino
'f' para feminino");

    sexo = char.Parse(Console.ReadLine());
    if (sexo == 'f')
    {
        totalMulher++;
    }
    else
    {
        totalHomem++;
    }

    Console.WriteLine(@$"Você gostou do produto?
's' (sim)
'n' (nao)");
    gostouDoProduto = char.Parse(Console.ReadLine());

    if (gostouDoProduto == 's')
    {
        totalSim++;

        if (sexo == 'f')
        {
            totalMulherSim++;
        }
        else
        {
            totalNao++;
            if (sexo == 'm')
            {
                totalHomemNao++;
            }
        }
    }
}

porcentagemHomemNao = Math.Round(((double)totalHomemNao / (double)totalHomem) * 100, 2);

Console.WriteLine($"O total de pessoas que responderam sim foi de : {totalSim}");
Console.WriteLine($"O total de pessoas que responderam Nao foi de : {totalNao}");
Console.WriteLine($"O total de mulheres que responderam sim foi de : {totalMulherSim}");
Console.WriteLine($"porcentagem de homens que responderam nao foi de : {porcentagemHomemNao}");

