//calcular a comissão 10% das vendas 
double[] vendas = { 100, 250.99, 300 };

Console.WriteLine("calcular o valor total e multiplica por 10% ");

double porcentagem = (vendas[0] + vendas[1] + vendas[2])*10;

double total = porcentagem / 100;

Console.WriteLine($"RESULTADO TOTAL:{total:F2} ");







/*double[] notas = new double[4];
notas[0] = 9.5;
notas[1] = 10;
notas[2] = 7;


double media = (notas[0] + notas[1] + notas[2])/3;
Console.WriteLine($"média: {media:F2}");
*/


/*Console.WriteLine(notas[0]);
Console.WriteLine("Digite a 3a nota:");

notas[2] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"3a Nota: {notas[2]}");

notas[1] =  8;
Console.WriteLine($"notas[1] {notas[1]}");
*/