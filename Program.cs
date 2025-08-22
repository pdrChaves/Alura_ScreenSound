// Screen Sound
using System.Xml.Linq;

String mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
Dictionary<string, List<int>> artistasRegistrados = new Dictionary<string, List<int>>();
artistasRegistrados.Add("Linkin Park", new List<int> { 10, 8, 6 });
artistasRegistrados.Add("U2", new List<int>());
void ExibirLogo()

{
    //uso do site "Fsymbols" para alterar a fonte 
    //Verbating Literal = @ "" para mostrar o que será exibido
    Console.WriteLine(      
        @"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
        "
        );
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma artista");
    Console.WriteLine("Digite 2 para mostrar todas os artistas registrados");
    Console.WriteLine("Digite 3 para avaliar um artista");
    Console.WriteLine("Digite 4 para exibir a média de um artista");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigie sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;    //! no final evita que receba um valor nulo
    int opcaoEscolhidaInt = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaInt) 
    {
        case 1: RegistrarArtista();
            break;
        case 2: MostrarArtistasRegistrados();
            break;
        case 3: AvaliarUmArtista();
            break;
        case 4: Console.WriteLine("Opção escolhida: " + opcaoEscolhida);
            break;
        case -1: Console.WriteLine("Programa encerrado.");
            Thread.Sleep(2000);
            break;
        default: Console.WriteLine("Opção inválida.");
            break;


    }       
}
void RegistrarArtista()
{
    Console.Clear();
    ExibirTituloDasOpcoes("Registar artista");
    Console.Write("Digite o nome do artista que deseja registrar: ");
    string nomeDoArtista = Console.ReadLine()!;
    artistasRegistrados.Add(nomeDoArtista, new List<int>());
    Console.WriteLine($"\nO artista {nomeDoArtista} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}
void MostrarArtistasRegistrados()
{
    Console.Clear();
    ExibirTituloDasOpcoes("Artistas registrados");
    /* for (int i = 0; i < listaDosArtistas.Count ; i++)
    {
        Console.WriteLine($"Artista: {listaDosArtistas[i]}");
    }
    */
    foreach (string nomeDoArtista in artistasRegistrados.Keys)
    {
        Console.WriteLine($"Artista: {nomeDoArtista}");
    }

    Console.WriteLine();
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}
void ExibirTituloDasOpcoes(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriisticos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriisticos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriisticos + "\n");
}
void AvaliarUmArtista()
{
    //digite o artista que deseja avaliar
    //caso o artista existir no dicionario >> atibuir uma nota
    //senao, voltar ao menu principal
    
    Console.Clear();
    ExibirTituloDasOpcoes("Avaliar Artista");
    Console.Write("Digite o nome do artista que deseja avaliar: ");
    string nomeDoArtista = Console.ReadLine()!;
    if (artistasRegistrados.ContainsKey(nomeDoArtista))
    {
        Console.Write($"Insira a nota para {nomeDoArtista}: ");
        int nota = int.Parse(Console.ReadLine()!);
        artistasRegistrados[nomeDoArtista].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para o artista {nomeDoArtista}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nO artista {nomeDoArtista} não foi encontrado...");
        Console.WriteLine("Pressione qualquer tecla para votlar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }


}
ExibirLogo();
ExibirOpcoesDoMenu();