// Screen Sound
String mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
void ExibirMensagemBoasVindas()
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
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigie sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;    //! no final evita que receba um valor nulo
    int opcaoEscolhidaInt = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaInt) 
    {
        case 1: Console.WriteLine("Opção escolhida: " + opcaoEscolhida);
            break;
        case 2: Console.WriteLine("Opção escolhida: " + opcaoEscolhida);
            break;
        case 3: Console.WriteLine("Opção escolhida: " + opcaoEscolhida);
            break;
        case 4: Console.WriteLine("Opção escolhida: " + opcaoEscolhida);
            break;
        case -1: Console.WriteLine("Programa encerrado.");
            break;
        default: Console.WriteLine("Opção inválida.");
            break;


    }       
}


ExibirMensagemBoasVindas();
ExibirOpcoesDoMenu();









// pratica 1 (Concluida)
/*
String curso = "cSharp";
String nome = "Pedro";
String sobrenome = "Chaves";
Console.WriteLine("Curso: "+curso);
Console.WriteLine("Instrutor: "+ nome +" "+ sobrenome);    
*/