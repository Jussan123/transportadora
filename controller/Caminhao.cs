namespace Controller
{
    public class Caminhao
    {
        private static void ValidaPlaca(
            string placa
        ) {
            string[] placaSplit = placa.Split('-');
            if (placaSplit.Length != 2) {
                throw new Exception("Placa é inválida, Verifique se a placa está no formato AAA-9999");
            }
            if (placaSplit[0].Length != 3) {
                throw new Exception("Placa é inválida, Verifique se a placa está no formato AAA-9999");
            }
            if (placaSplit[1].Length != 4) {
                throw new Exception("Placa é inválida, Verifique se a placa está no formato AAA-9999");
            }
 
            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numeros = "0123456789";
 
            foreach (char letra in placaSplit[0]) {
                if (!letras.Contains(letra.ToString())) {
                    throw new Exception("Placa inválida - Verifique se a placa está no formato AAA-9999");
                }
            }
 
            foreach (char numero in placaSplit[1]) {
                if (!numeros.Contains(numero.ToString())) {
                    throw new Exception("Placa inválida - Verifique se a placa está no formato AAA-9999");
                }
            }
        }

        public static void CadastraCaminhao(
            string id, 
            string placa, 
            string motorista, 
            string rota, 
            string valor)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
 
            ValidaPlaca(placa);
            Model.Caminhao caminhao = new Model.Caminhao(idConvert, placa, motorista, rota, valor);
        }

        public static void AlteraCaminhao(
            string id, 
            string placa, 
            string motorista, 
            string rota, 
            string valor) 
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
 
            ValidaPlaca(placa);
            Model.Caminhao.AlteraCaminhao(idConvert, placa, motorista, rota, valor);
        }

        public static void ExcluiCaminhao(string id) 
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
 
            Model.Caminhao.ExcluiCaminhao(idConvert);
        }

        public static Model.Caminhao BuscaCaminhao(string id) 
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
 
            return Model.Caminhao.BuscaCaminhao(idConvert);
        }

        public static List<Model.Caminhao> ListaCaminhao() 
        {
            return Model.Caminhao.ListaCaminhao();
        }

        public static int SomaRotas() 
        {
            return Model.Caminhao.TotalRotasCaminhao();
        }

        public static double SomaValor() 
        {
            return Model.Caminhao.TotalValorCaminhao();
        }
    }
}