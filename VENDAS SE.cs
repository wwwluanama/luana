Console.WriteLine("Digite o preço do produto");
double preco = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a quantidade de produto: ");

int qtd = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a opção de pagamento: ");
string opcao = Console.ReadLine();

if (opcao == "prazo")
{
    double valor = preco * qtd;
    double acrescimo = valor * 3 / 100;
    double valorFinal = valor + acrescimo;

    Console.WriteLine($"Total: {valorFinal}");


}

else
{
    double valor = preco * qtd;
    double desconto = valor * 10 / 100;
    double valorFinal = valor - desconto;

    Console.WriteLine($"Total: {valorFinal}");
}
