using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    public class Rota
    {
        private int Id { get; set; }
        private string Partida { get; set; }
        private string Chegada { get; set; }
        private int CaminhaoId { get; set; }
        private string Data { get; set; }
        private double Valor { get; set; }

        public Caminhao Caminhao { get; set; }
        public DateTime DataRota { get; set; }
        public Cidade CidadeOrigem { get; set; }
        public Cidade CidadeDestino { get; set; }

        public static List<Rota> Rotas { get; set; } = new List<Rota>();

        public Rota(int id, string partida, string chegada, string data, Caminhao caminhao, double valor)
        {
            Id = id;
            Partida = partida;
            Chegada = chegada;
            Data = data;
            Caminhao = caminhao;
            CaminhaoId = caminhao.id;
            Valor = valor;

            Rotas.Add(this);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Origem: {Partida}, Destino: {Chegada}, Caminhão: {Caminhao}, Data: {Data}, Valor: {Valor}";
        }

        public static void AlteraRota(int id, string partida, string chegada, string data, Caminhao caminhao, double valor)
        {
            Rota rota = BuscaRota(id);
            rota.Partida = partida;
            rota.Chegada = chegada;
            rota.Caminhao = caminhao;
            rota.Data = data;
            rota.Valor = valor;
        }

        public static void ExcluiRota(int id)
        {
            Rota rota = BuscaRota(id);
            Rotas.Remove(rota);
        }

        public static Rota BuscaRota(int id)
        {
            Rota rota = Rotas.Find(r => r.Id == id);
            if (rota == null)
            {
                throw new Exception("Rota não encontrada");
            }

            return rota;
        }

        public static double TotalValorCaminhao(int id)
        {
            double total = (from rota in Rotas
                            where rota.CaminhaoId == id
                            select rota.Valor).Sum();

            return total;
        }

        public static int TotalRotasCaminhao(int id)
        {
            int total = (from rota in Rotas
                         where rota.CaminhaoId == id
                            select rota).Count();

            return total;
        }
    }
}
