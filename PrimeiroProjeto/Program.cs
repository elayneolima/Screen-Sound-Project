﻿
#region Var globais
string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";
#endregion

#region Funcao exibe mensagem
void ExibirMensagemBoasVindas()
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
        case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
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

#region Chamada das funcoes
ExibirMensagemBoasVindas();
ExibirOpcoesDoMenu();
#endregion
