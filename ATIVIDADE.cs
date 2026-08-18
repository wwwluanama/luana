//PRIMEIRA ATIVIDADE

/*Console.WriteLine("Digite uma idade: ");

int idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Aprovado");

}
 else
{
    Console.WriteLine("Você não esta aprovado por ser de menor de idade");

}
*/





// SEGUNDA ATIVIDADE
/*
Console.WriteLine("Digite a 1a nota: ");
double n1 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Digite a 2a nota: ");
double n2 = Convert.ToDouble(Console.ReadLine());

double media = (n1 + n2) / 2;


if ( media >= 7 )
{
    Console.WriteLine("Aprovado.");

}

else
{
    Console.WriteLine("Abaixo da média, reprovado");
    Console.WriteLine("> Fale com a coordenação para iniciar a recuperação! <");
    Console.WriteLine("Digite a nota da recuperação: ");
    double recuperacao = Convert.ToDouble(Console.ReadLine());
   if ( recuperacao >= 8)
     {
        Console.WriteLine("Você recuperou sua nota.");
    }
   else
    {
        Console.WriteLine("Reprovado.");
    }
}
*/





// TERCEIRA ATIVIDADE

//GERAR NÚMERO ALEATÓRIO DE 1 A 5


/*
Random gerador = new Random();
int numAleatorio = gerador.Next(1, 6);

Console.WriteLine("Digite um número entre 1 a 5: ");
int palpite = Convert.ToInt32(Console.ReadLine());

if (palpite == numAleatorio)
{
    Console.WriteLine(" Você acertou, retire seu prêmio em breve!! ");
}

else
{
    Console.WriteLine("Você errou, não a outra tentativa.");
}
*/


Console.WriteLine("Digite a quantidade de dias investidos: ");
int dias = Convert.ToInt32(Console.ReadLine());

if ( dias <= 180)
{
    Console.WriteLine("IR: 22,5%");

}

if (dias > 180 && dias <= 360)
{
    Console.WriteLine("IR: 20,0%");

}

if ( dias > 360)
{
    Console.WriteLine("IR: 17,5%");
}


