//Screen Sound

string boasVindas = "Sejam bem vindos ao Screen Sound";

List<string> listaDasBandas = new List<string>();

void ExibirMensagemdeBoasVindas()
{
    Console.WriteLine(@"

    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(boasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirMensagemdeBoasVindas();
    Console.WriteLine();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para ver a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.WriteLine();

    Console.Write("Digite sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    Console.WriteLine();

    switch (opcaoEscolhida)
    {
        case 1: RegistrarBanda(); break;
        case 2: MostrarBandasRegistradas(); break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida); break;
        case 4: Console.WriteLine("Você escolheu a ópção " + opcaoEscolhida); break;
        case -1: Console.WriteLine("Adios, Bye, Arivederti, Tchau :p "); break;
        default: Console.WriteLine("Escolha um opção valida"); break;
    }

}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de Bandas");
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeBanda);
    Console.WriteLine($"A banda {nomeBanda} foi adicionada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("Exibindo todas as bandas registradas");
    for (int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }
    Console.WriteLine("Pressione qualquer tecla para retornar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();