using System;
using System.IO;

class Programa
{
    static void Main(string[] args)
    {
        string menu = "";

        while (menu != "0")
        {
            Console.Clear(); 

            Console.WriteLine("==========================");
            Console.WriteLine("Escolha uma opcao abaixo:");
            Console.WriteLine("==========================");
            Console.WriteLine("1 - Cadastrar alfabeto");
            Console.WriteLine("2 - Listar alfabetos");
            Console.WriteLine("3 - Validar simbolo");
            Console.WriteLine("4 - Validar cadeia");
            Console.WriteLine("5 - Testar linguagem simples");
            Console.WriteLine("6 - Salvar / carregar JSON");
            Console.WriteLine("7 - Gerar relatório");
            Console.WriteLine("8 - Tabela-verdade P e Q");
            Console.WriteLine("9 - Simular custo");
            Console.WriteLine("10 - Operações de fechamento");
            Console.WriteLine("11 - Reconhecedor com limite");
            Console.WriteLine("12 - Classificar arquivo");
            Console.WriteLine("13 - Importar / exportar projeto");
            Console.WriteLine("0 - Sair\n");
          
            Console.WriteLine("==========================");
            Console.WriteLine("Digite a opcao desejada:");
            Console.WriteLine("==========================");

            menu = Console.ReadLine();

            Relatorio.Registrar(menu);

            switch (menu)
            {
                case "1":
                    Console.WriteLine("Em construcao\n");
                    break;

                case "2":
                    Console.WriteLine("Em construcao.\n");
                    break;

                case "3":
                    Console.WriteLine("Em construcao.\n");
                    break;

                case "4":
                    Console.WriteLine("Em construcao.\n");
                    break;

                case "5":
                    Console.WriteLine("Em construcao.\n");
                    break;

                case "6":
                    Console.WriteLine("Testando persistência...");
                    Persistencia.Salvar();
                    Persistencia.Carregar();
                    Console.WriteLine("Teste de salvar/carregar concluído.");
                    break;

                case "7":
                    Console.WriteLine("Em construcao.\n");
                    break;

                case "8":
                    Console.WriteLine("Em construcao.");
                    break;

                case "9":
                    Console.WriteLine("Em construcao.\n");
                    break;

                case "10":
                    Console.WriteLine("Em construcao.\n");
                    break;
                
                case "11":
                    Console.WriteLine("Em construcao.\n");
                    break;

                case "12":
                    Console.WriteLine("Em construcao.\n");
                    break;

                case "13":
                    Console.WriteLine("Em construcao.\n");
                    break;

                case "0":
                    Console.WriteLine("Programa encerrado\n");
                    break;

                default:
                    Console.WriteLine("Opcao invalida! Tente novamente.\n");
                    break;
            }

            if (menu != "0")
            {
                Console.WriteLine("\nPressione enter tecla para voltar ao menu.");
                Console.ReadKey();
            }
        }
    }
}

class Alfabeto
{
    public string Nome { get; set; }

    public Alfabeto(string nome)
    {
        Nome = nome;
    }
}

class Servicos
{

}

class Persistencia
{
    private static string caminho = "data/alfabetos.json";

    public static void Salvar()
    {
        try
        {
            if (!Directory.Exists("data"))
                Directory.CreateDirectory("data");

            string json = "{}"; 
            File.WriteAllText(caminho, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao salvar: {ex.Message}");
        }
    }

    public static void Carregar()
    {
        try
        {
            if (File.Exists(caminho))
            {
                string json = File.ReadAllText(caminho);
              // implemetar aqui 
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao carregar: {ex.Message}");
        }
    }
}

class Relatorio
{
    private static string caminho = "data/relatorio.txt";

    public static void Registrar(string opcao)
    {
        try
        {
            if (!Directory.Exists("data"))
                Directory.CreateDirectory("data");

            string nomeOpcao;

            switch (opcao)
            {
                case "1":
                    nomeOpcao = "Cadastrar alfabeto";
                    break;
                case "2":
                    nomeOpcao = "Listar alfabetos";
                    break;
                case "3":
                    nomeOpcao = "Validar simbolo";
                    break;
                case "4":
                    nomeOpcao = "Validar cadeia";
                    break;
                case "5":
                    nomeOpcao = "Testar linguagem simples";
                    break;
                case "6":
                    nomeOpcao = "Salvar / carregar JSON";
                    break;
                case "7":
                    nomeOpcao = "Gerar relatório";
                    break;
                case "8":
                    nomeOpcao = "Tabela-verdade P e Q";
                    break;
                case "9":
                    nomeOpcao = "Simular custo";
                    break;
                case "10":
                    nomeOpcao = "Operações de fechamento";
                    break;
                case "11":
                    nomeOpcao = "Reconhecedor com limite";
                    break;
                case "12":
                    nomeOpcao = "Classificar arquivo";
                    break;
                case "13":
                    nomeOpcao = "Importar / exportar projeto";
                    break;
                case "0":
                    nomeOpcao = "Sair";
                    break;
                default:
                    nomeOpcao = "Opção inválida";
                    break;
            }

            string linha = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {nomeOpcao} - ok";
            File.AppendAllText(caminho, linha + Environment.NewLine);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao registrar relatório: {ex.Message}");
        }
    }
}
