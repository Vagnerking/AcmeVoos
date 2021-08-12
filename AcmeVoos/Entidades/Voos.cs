using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeVoos.Entidades
{
    public class Voos
    {
        public int ID_VOO { get; set; }
        public DateTime DATA_VOO { get; set; }
        public double CUSTO { get; set; }
        public int DISTANCIA { get; set; }
        public char CAPTURA { get; set; }
        public int NIVEL_DOR { get; set; }

        public Voos() { }

        public Voos(int id, DateTime dataVoo, double custo, int distancia, char captura, int nivelDor)
        {
            ID_VOO = id;
            DATA_VOO = dataVoo;
            CUSTO = custo;
            DISTANCIA = distancia;
            CAPTURA = captura;
            NIVEL_DOR = nivelDor;
        }


    }
}
