
#region Globais
string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";
List<string> listaDasBandas = new List<string>();
#endregion

#region Funcao exibe mensagem
void ExibirLogo()

{ 
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

#endregion

#region Funcao exibir opcoes menu
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda ");
    Console.WriteLine("Digite 2 para listar uma banda ");
    Console.WriteLine("Digite 3 para avaliar uma banda ");
    Console.WriteLine("Digite 4 para visualizar a media de uma banda ");
    Console.WriteLine("Digite -1 para sair ");

    Console.Write("\nDigite uma opção: ");
    string opcaoEscolhida = Console.ReadLine()!; 
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNum) 
    {
        case 1: RegistrarBanda();
            break;
        case 2: Console.WriteLine("Você escolheu a opção 2");
            break;
        case 3: Console.WriteLine("Você escolheu a opção 3");
            break;
        case 4: Console.WriteLine("Você escolheu a opção 4"); 
            break;
        case -1: Console.WriteLine("Até breve! :)");
            break;
        default: Console.WriteLine("opção inválida!");
            break;

    }

}
#endregion

#region Funcao RegistrarBanda
void RegistrarBanda()
{
    Console.Clear();
    Console.Write("Digite o nome da banda:");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    listaDasBandas.Add(nomeDaBanda); 
    //string valorArmazenado = listaDasBandas[0]; #var para armazenar o valor/posicao adicionado a lista
    //Console.WriteLine($"valor armazenado: {valorArmazenado}"); #exibe o valor no indice indicado 
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();

}
#endregion

#region Chamada das funcoes
ExibirOpcoesDoMenu();
#endregion
