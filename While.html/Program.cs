/*int i = 0;
while (i <= 10)
{
    Console.WriteLine(i);
    i = i + 1;
}
*/

/*
int i = 10;
while (i > 0)
{
    Console.WriteLine(i);
    i = i - 1;
}

*/

//Utilize o WHILE para ler dois números e somá-los
//o sistema deve fazer isso 3 vezes


int i = 0;
while(i < 3)
{
    Console.WriteLine("Digite qualquer número");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o segundo número");
    int n2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Resultado da soma:  {n1 + n2}");
    Console.WriteLine("-------------------------");

    i = i + 1;
}

