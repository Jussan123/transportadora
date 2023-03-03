namespace Controller
{
    public class Cidade
    {
        public static void cadastraCidade(string id, string nome)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            Model.Cidade cidade = new Model.Cidade(idConvert, nome);
        }

        public static void AlteraCidade(string id, string nome)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            Model.Cidade.AlteraCidade(idConvert, nome);
        }

        public static void ExcluiCidade(string id)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            Model.Cidade.ExcluiCidade(idConvert);
        }

        public static Model.Cidade BuscaCidade(string id)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            return Model.Cidade.BuscaCidade(idConvert);
        }

        public static List<Model.Cidade> ListaCidades()
        {
            return Model.Cidade.Cidades;
        }
    }
}