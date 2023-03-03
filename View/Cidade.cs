namespace View
{
    public class Cidade
    {
        public static void CadastraCidade()
        {
            Console.WriteLine("Cadastre uma Cidade no Sistema");
            Console.WriteLIne("Digite o Id da cidade:");
            string id = Console.ReadLine();
            Console.WriteLine("Digite o nome da cidade:");
            string nome = Console.ReadLine();
            try {
                Controller.Cidade.CadastraCidade(id, nome);
                Console.WriteLine("Cidade cadastrada com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao cadastrar cidade: {e.Message}");
            }
        }

        public static void alteraCidade()
        {
            Console.WriteLine("Altere o cadastro de uma Cidade no Sistema");
            Console.WriteLine("Digite o Id da cidade:");
            string id = Console.ReadLine();
            Console.WriteLine("Digite o nome da cidade:");
            string nome = Console.ReadLine();
            try {
                Controller.Cidade.alteraCidade(id, nome);
                Console.WriteLine("Cidade alterada com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao alterar cidade: {e.Message}");
            }
        }

        public static void removeCidade()
        {
            Console.WriteLine("Remova uma Cidade cadastrada do Sistema");
            Console.WriteLine("Digite o Id da cidade:");
            string id = Console.ReadLine();
            try {
                Controller.Cidade.removeCidade(id);
                Console.WriteLine("Cidade removida com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao remover cidade: {e.Message}");
            }
        }

        public static void ListaCidade()
        {
            Console.WriteLine("Listar cidades cadastradas");
            foreach (Model.Cidade cidade in Controller.Cidade.ListaCidade()) {
                Console.WriteLine(cidade);
            }
        }
    }
}