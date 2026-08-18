int quantidade = 3;
int[] numero = new int[quantidade];

double[] preco = new double[quantidade];
double[] total = new double[quantidade];

Console.WriteLine("Cálculo da quantidade.");
//int
Console.WriteLine("Escreva o 1o número: ");
numero[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escreva o 2o número: ");
numero[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escreva o 3o número: ");
numero[2] = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Cálculo total.");
//double
Console.WriteLine("Escreva o 1o número: ");
preco[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escreva o 2o número: ");
preco[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escreva o 3o número: ");
preco[2] = Convert.ToInt32(Console.ReadLine());


total[0] = numero[0] * preco[0];
total[1] = numero[1] * preco[1];
total[2] = numero[2] * preco[2];

Console.WriteLine($"Total 1: {preco[0]}");

Console.WriteLine($"Total 2: {total[1]}");

Console.WriteLine($"Total 3: {total[2]}");

