using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeropuertoSofi.Aerolinea
{

    public class Equipaje
    {
        private string tipo;
        private string sellado;
        private long dinero;
        private long dinero2;
        private int pagar;
        public Equipaje()
        {
            tipo = "";
            sellado = "";
            dinero = 0;
            dinero2 = 0;
            pagar = 0;
        }
        public string TIP0
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string SELLAD
        {
            get { return sellado; }
            set { sellado = value; }
        }
        public void calculardinero()
        {
            
            dinero = (dinero - 5000000);

        }
      
        public long DINER
        {
            get { return dinero; }
            set { dinero = value; }
        }
        public long DINER2
        {
            get { return dinero2; }
            set { dinero2 = value; }
        }
        public int PAGR
        {
            get { return pagar; }
            set { pagar = value; }
        }

    }
}
