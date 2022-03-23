using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeropuertoSofi.Aerolinea;

namespace AeropuertoSofi.Aerolinea
{
    internal class Negocio
    {
        private List<Vuelo> misvuelos;
        private List<Pasajero> mispasajeros;
        private List<Equipaje> miequipaje;


        public Negocio()
        {
            misvuelos = new List<Vuelo>();
            mispasajeros = new List<Pasajero>();
            miequipaje = new List<Equipaje>();
        }


        public List<Vuelo> VU
        {
            set { misvuelos = value; }
            get { return misvuelos; }
        }
        public List<Pasajero> Pasa
        {
            set { mispasajeros = value; }
            get { return mispasajeros; }
        }
        public List<Equipaje> EQUI
        {
            set { miequipaje = value; }
            get { return miequipaje; }
        }


    }
}
