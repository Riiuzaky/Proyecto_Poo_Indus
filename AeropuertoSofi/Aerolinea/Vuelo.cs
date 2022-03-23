using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeropuertoSofi.Aerolinea
{
    public class Vuelo
    {
        private string destino;
        private DateTime fecha;
        private string menu;
        private string clase;
        private float tiketes;
       



        public Vuelo()
        {
            destino = "";            
            menu = "";
            fecha = DateTime.Now;
            clase = "";
            tiketes = 0;
           


        }

        public string DES
        {
            get { return destino; }
            set { destino = value; }
        }
        public DateTime FEC
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string CLAS
        {
            get { return clase; }
            set { clase = value; }
        }
        public string MEN
        {
            get { return menu; }
            set { menu = value; }
        }
        public float Tik
        {
            get { return tiketes; }
            set { tiketes = value; }
        }





    }
}

