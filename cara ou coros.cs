/*Random gerador = new Random();

int numAleatorio = gerador.Next(1, 3);
string moeda;

if ( numAleatorio == 1)
{
    moeda = "cara";
}

else
{
    moeda = "coroa";
}

Console.WriteLine("Faça uma escolha entre cara ou coroa");
string Palpite = Console.ReadLine();
 if (moeda == Palpite)
{
    Console.WriteLine ("Acertou");

}

else
{
    Console.WriteLine("Errou");
}
*/

//ler 2 números e verificar qual o maior.

Console.WriteLine("Digite dois números");

Console.WriteLine("Digite o primeiro número: ");
int num1 = Convert.ToInt32 (Console.ReadLine());


Console.WriteLine("Digite o segundo número: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if ( num1 > num2)
{
    Console.WriteLine(" primeiro é o maior que o segundo. ");

}

else
{
    Console.WriteLine("O segundo é maior que o primeiro.");
}



