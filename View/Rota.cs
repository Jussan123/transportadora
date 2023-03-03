namespace View
{
    public class Rota
    {
        public static void CadastraRota()
        {
            Console.WriteLine("Cadastre uma rota no sistema");
            Console.WriteLine("Digite o id da rota:");
            string id = Console.ReadLine();
            Console.WriteLine("Digite o id da cidade de origem:");
            string idOrigem = Console.ReadLine();
            Console.WriteLine("Digite o id da cidade de destino:");
            string idDestino = Console.ReadLine();
            Console.WriteLine("Digite a distancia da rota:");
            string distancia = Console.ReadLine();
            Console.WriteLine("Digite o valor da rota:");
            string valor = Console.ReadLine();
            try {
                Controller.Rota.CadastraRota(id, idOrigem, idDestino, distancia, valor);
                Console.WriteLine("Rota cadastrada com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao cadastrar rota: {e.Message}");
            }
        }

        public static void alteraRota()
        {
            Console.WriteLine("Altere o cadastro de uma rota no sistema");
            Console.WriteLine("Digite o id da rota:");
            string id = Console.ReadLine();
            Console.WriteLine("Digite o id da cidade de origem:");
            string idOrigem = Console.ReadLine();
            Console.WriteLine("Digite o id da cidade de destino:");
            string idDestino = Console.ReadLine();
            Console.WriteLine("Digite o valor da rota:");
            string valor = Console.ReadLine();
            try {
                Controller.Rota.alteraRota(id, idOrigem, idDestino, valor);
                Console.WriteLine("Rota alterada com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao alterar rota: {e.Message}");
            }
        }

        public static void removeRota()
        {
            Console.WriteLine("Remova uma rota cadastrada no sistema");
            Console.WriteLine("Digite o id da rota:");
            string id = Console.ReadLine();
            try {
                Controller.Rota.removeRota(id);
                Console.WriteLine("Rota removida com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao remover rota: {e.Message}");
            }
        }

        public static void ListaRotas()
        {
            Console.WriteLine("Listar rotas cadastradas");
            foreach (Model.Rota rota in Controller.Rota.ListaRotas()) {
                Console.WriteLine(rota);
            }
        }

        public static void ListaRotasPorCidade()
        {
            Console.WriteLine("Listar rotas cadastradas por cidade");
            Console.WriteLine("Digite o id da cidade:");
            string id = Console.ReadLine();
            foreach (Model.Rota rota in Controller.Rota.ListaRotasPorCidade(id)) {
                Console.WriteLine(rota);
            }
        }

        public static void ListaRotasPorCaminhao()
        {
            Console.WriteLine("Listar rotas cadastradas por caminhão");
            Console.WriteLine("Digite o id do caminhão:");
            string id = Console.ReadLine();
            foreach (Model.Rota rota in Controller.Rota.ListaRotasPorCaminhao(id)) {
                Console.WriteLine(rota);
            }
        }

        public static void ListaRotasPorData()
        {
            Console.WriteLine("Listar rotas cadastradas por data");
            Console.WriteLine("Digite a data:");
            string data = Console.ReadLine();
            foreach (Model.Rota rota in Controller.Rota.ListaRotasPorData(data)) {
                Console.WriteLine(rota);
            }
        }
    }
}