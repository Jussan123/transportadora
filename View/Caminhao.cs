namespace View
{
    public class Caminhao
    {
        public static void CdastrarCaminhao()
        {
            Console.WriteLine("Cadastre um caminhão no sistema");
            Console.WriteLine("Digite o id do caminhão:");
            string id = Console.ReadLine();
            Console.WriteLine("Digite a placa do caminhão:");
            string placa = Console.ReadLine();
            Console.WriteLine("Digite o motorista do caminhão:");
            string motorista = Console.ReadLine();
            try
            {
                Controller.Caminhao.CadastrarCaminhao(id, placa, motorista);
                Console.WriteLine("Caminhão cadastrado com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao cadastrar caminhão: {e.Message}");
            }
        }

        public static void AlteraCaminhao()
        {
            Console.WriteLine("Altere um caminhão no sistema");
            Console.WriteLine("Digite o id do caminhão:");
            string id = Console.ReadLine();
            Console.WriteLine("Digite a placa do caminhão:");
            string placa = Console.ReadLine();
            Console.WriteLine("Digite o motorista do caminhão:");
            string motorista = Console.ReadLine();
            try
            {
                Controller.Caminhao.AlteraCaminhao(id, placa, motorista);
                Console.WriteLine("Caminhão alterado com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao alterar caminhão: {e.Message}");
            }
        }

        public static void RemoveCaminhao()
        {
            Console.WriteLine("Remova um caminhão no sistema");
            Console.WriteLine("Digite o id do caminhão:");
            string id = Console.ReadLine();
            try
            {
                Controller.Caminhao.RemoveCaminhao(id);
                Console.WriteLine("Caminhão removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao remover caminhão: {e.Message}");
            }
        }

        public static void ListaCaminhoes()
        {
            Console.WriteLine("Liste os caminhões no sistema");
            foreach (Model.Caminhao caminhao in Controller.Caminhao.ListaCaminhoes())
            {
                Console.WriteLine(caminhao);
            }
        }

        public static void ListaValorPorCaminhoes()
        {
            Console.WriteLine("Liste o valor total dos caminhões no sistema");
            Console.WriteLine(Controller.Caminhao.ListaValorPorCaminhoes());
        }
    }
}