namespace Principal
{
    class Menu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Gerenciamento de Cidades e Caminhões");
            Console.WriteLine("1 - Cadastro de rotas.");
            Console.WriteLine("2 - Cadastro de cidades.");
            Console.WriteLine("3 - Cadastro de caminhões.");
            Console.WriteLine("4 - Alterar rotas.");
            Console.WriteLine("5 - Alterar cidades.");
            Console.WriteLine("6 - Alterar caminhões.");
            Console.WriteLine("7 - Remover rotas.");
            Console.WriteLine("8 - Remover cidades.");
            Console.WriteLine("9 - Remover caminhões.");
            Console.WriteLine("10 - Buscar rotas.");
            Console.WriteLine("11 - Buscar cidades.");
            Console.WriteLine("12 - Buscar caminhões.");
            Console.WriteLine("13 - Listar rotas.");
            Console.WriteLine("14 - Listar cidades.");
            Console.WriteLine("15 - Listar caminhões.");
            Console.WriteLine("16 - Listar rotas por cidade.");
            Console.WriteLine("17 - Listar rotas por caminhão.");
            Console.WriteLine("18 - Listar rotas por data.");
            Console.WriteLine("19 - Listar valor por Caminhões.");
            Console.WriteLine("20 - Sair.");
            Console.WriteLine("Digite a opção desejada: ");
            int opcao = int.Parse(Console.ReadLine());
            
            switch (opcao)
            {
                case 1:
                    View.Rota.CadastraRota();
                    break;
                case 2:
                    View.Cidade.CadastraCidade();
                    break;
                case 3:
                    View.Caminhao.CadastraCaminhao();
                    break;
                case 4:
                    View.Rota.AlteraRota();
                    break;
                case 5:
                    View.Cidade.AlteraCidade();
                    break;
                case 6:
                    View.Caminhao.AlteraCaminhao();
                    break;
                case 7:
                    View.Rota.ExcluiRota();
                    break;
                case 8:
                    View.Cidade.ExcluiCidade();
                    break;
                case 9:
                    View.Caminhao.ExcluiCaminhao();
                    break;
                case 10:
                    View.Rota.BuscaRota();
                    break;
                case 11:
                    View.Cidade.BuscaCidade();
                    break;
                case 12:
                    View.Caminhao.BuscaCaminhao();
                    break;
                case 13:
                    View.Rota.ListaRotas();
                    break;
                case 14:
                    View.Cidade.ListaCidades();
                    break;
                case 15:
                    View.Caminhao.ListaCaminhoes();
                    break;
                case 16:
                    View.Rota.ListaRotasPorCidade();
                    break;
                case 17:
                    View.Rota.ListaRotasPorCaminhao();
                    break;
                case 18:
                    View.Rota.ListaRotasPorData();
                    break;
                case 19:
                    View.Caminhao.ListaValorPorCaminhoes();
                    break;
                case 20:
                    Console.WriteLine("Saindo do sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
    }
}