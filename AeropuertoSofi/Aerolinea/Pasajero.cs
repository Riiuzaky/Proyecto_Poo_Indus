using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeropuertoSofi.Aerolinea
{
    public class Pasajero
    {
        private string comprador;
        private long documento;
        private long pasaporte;
        private string direccion;
        private float edad;
        private float expedicion;
          private float expedicion2;
                    
     


        public Pasajero()
        {
            comprador = "";
            documento = 0;
            pasaporte = 0;
            direccion = "";
            edad = 0;
            expedicion = 0;
            expedicion2 = 0;

        }
        public string COMP
        {
            get { return comprador; }
            set { comprador = value; }
        }
        public long DOC
        {
            get { return documento; }
            set { documento = value; }
        }
        public long  PASAP
        {
            get { return pasaporte; }
            set { pasaporte = value; }
        }
        public float EDAD
        {
            get { return edad; }
            set { edad = value; }
        }
        public string DIRECC
        {
            get { return direccion; }
            set { direccion = value; }

        }
        public void calcularexpedicion()
        {
            expedicion2 = expedicion;
            expedicion = ( 2022 - expedicion) ;

        }
        public float EXPE
        {
            get { return expedicion; }
            set { expedicion = value; }
        }

       


    }
}

    
