using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    public class Caminhao
    {
        public int Id { get; set; }
        public string Placa { get; set; } // validar a placa
        public string Motorista { get; set; }

        public static List<Caminhao> Caminhoes = new List<Caminhao>();

        public Caminhao(int id, string placa, string motorista)
        {
            this.Id = id;
            this.Placa = placa;
            this.Motorista = motorista;

            Caminhoes.Add(this);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Placa: {Placa}, Motorista: {Motorista}";
        }

        public static void AlteraCaminhao(int id, string placa, string motorista)
        {
            Caminhao caminhao = BuscarCaminhao(id);
            caminhao.Placa = placa;
            caminhao.Motorista = motorista;
        }

        public static void ExcluiCaminhao(int id)
        {
            Caminhao caminhao = BuscaCaminhao(id);
            Caminhoes.Remove(caminhao);
        }

        public static Caminhao BuscaCaminhao(int id)
        {
            Caminhao caminhao = Caminhoes.Find(c => c.Id == id);
            if (caminhao == null)
            {
                throw new Exception("Caminhão não encontrado");
            }
            return caminhao;
        }

        public static double TotalValorCaminhao(int id)
        {
            double total = (from rota in Rota.Rotas
                            where rota.CaminhaoId == id
                            select rota.Valor).Sum();
            return total;
        }

        public static int TotalRotasCaminhao(int id)
        {
            int total = (from rota in Rota.Rotas
                         where rota.CaminhaoId == id
                         select rota).Count();
            return total;
        }
    }
}
