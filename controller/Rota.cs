namespace Controller
{
    public class Rota
    {
        public static void CadastraRota(
            string id,
            string OrigemId,
            string DestinoId,
            string Caminhaoid,
            string data,
            string valor
        )
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            int OrigemIdConvert = 0;
            try {
                OrigemIdConvert = int.Parse(OrigemId);
            } catch (Exception) {
                throw new Exception("OrigemId inválido");
            }
            Model.Cidade origem = Model.Cidade.BuscaCidade(OrigemIdConvert);
            Model.Cidade destino = Model.Cidade.BuscaCidade(int.Parse(DestinoId));
            Model.Caminhao caminhao = Model.Caminhao.BuscaCaminhao(int.Parse(Caminhaoid));
            DateTime dataConvert = DateTime.Parse(data);
            valor = Model.Rota.Valor.Replace(".", ",");
            Model.Rota rota = new Model.Rota(idConvert, origem, destino, caminhao, dataConvert, valor);
        }

        public static void AlteraRota(
            string id,
            string OrigemId,
            string DestinoId,
            string Caminhaoid,
            string data,
            string valor
        )
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            Model.Cidade origem = Model.Cidade.BuscaCidade(int.Parse(OrigemId));
            Model.Cidade destino = Model.Cidade.BuscaCidade(int.Parse(DestinoId));
            Model.Caminhao caminhao = Model.Caminhao.BuscaCaminhao(int.Parse(Caminhaoid));
            DateTime dataConvert = DateTime.Parse(data);
            valor = Model.Rota.Valor.Replace(".", ",");
            Model.Rota.AlteraRota(idConvert, origem, destino, caminhao, dataConvert, valor);
        }

        public static void ExcluiRota(string id)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            Model.Rota.ExcluiRota(idConvert);
        }

        public static Model.Rota BuscaRota(string id)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            return Model.Rota.BuscaRota(idConvert);
        }

        public static List<Model.Rota> ListaRota()
        {
            List<string>  stringRotas = new List<string>();
            IEnumerable<Model.Rota> rotas = from rota in Model.Rota.Rotas
                join origem in Model.Cidade.Cidades on rota.Origem.Id equals origem.id
                join destino in Model.Cidade.Cidades on rota.Destino.Id equals destino.Id
                join caminhao in Model.Caminhao.Caminhoes on rota.Caminhao.ID equals caminhao.Id 
                select rota;

            foreach (Model.Rota rota in rotas) {
                stringRotas.Add($"Id: {rota.Id}, Origem: {rota.Origem.Nome}, Destino: {rota.Destino.Nome}, Caminhao: {rota.Caminhao.Placa}, Data: {rota.Data}, Valor: {rota.Valor}");
            }
            return stringRotas;
        }
    }
}
