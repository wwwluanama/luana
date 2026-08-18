//definir a palavra
string[] palavras =
{
    "casa",
    "carro",
    "livro",
    "janela",
    "computador",
    "telefone",
    "montanha",
    "rio",
    "sol",
    "amigo"
};
Console.WriteLine(" \n  Jogo da forca!!");
/*Console.WriteLine(" \nDigite a palavra que será advinhada");*/
Random r = new Random();
int numeroSorteado = r.Next(0, 10);
string palavra = palavras[numeroSorteado];


//criar uma representação com *
char[] representacao = new char[palavra.Length];
int i = 0;
while ( i < representacao.Length)
{
    representacao[i] = '*'; 
    
    i = i + 1;
}


//teste 1
i = 0;
while (i < representacao.Length)
{
    Console.WriteLine(representacao[i]);
    i = i + 1;
}


//definir a quantidade de tentativas
int tentativas = 6;

//estrutura de repitação
while (true)
{

    //escolher uma letra
    Console.WriteLine("\nDigite uma letra");
    Console.WriteLine("\n");
    
    char letra = Convert.ToChar(Console.ReadLine());

    //verificar se a palavra possui essa letra 
    i = 0;
    bool encontrou = false;
    while(i < representacao.Length)
    {

        if(letra == palavra[i])
        {
            // se sim
            //inserir uma letra na representaçao
            representacao[i] = letra;
            encontrou = true;

        }
        i = i + 1;
    }



    //teste2 
    i = 0;
    Console.WriteLine("----------");
    while (i < representacao.Length)
    {
        Console.Write(representacao[i]);

        i = i + 1;
    }

    //se não


    // diminuir o número de tentativas 
    if (encontrou== false)
    {
        tentativas = tentativas -1;
    }
    Console.WriteLine($"\nTentativas: {tentativas}");


    //verificar se a pessoa acertou a palavra
    bool concluiu = true;
    i = 0;
    while(i< palavra.Length)
    {
        if (palavra[i] != representacao[i])
        {
            concluiu = false;
        }
        i = i + 1;
    }


    //parabenizar e parar o jogo
    if ( concluiu == true)
    {
        Console.WriteLine("parabéns");
        break;
    }
    //verificar se a pessoa perdeu
    if (tentativas == 0)
    {
        Console.WriteLine("você perdeu");
        break;
    }
    //lamentar e parar o jogo

}
