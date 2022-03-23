using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AeropuertoSofi.Aerolinea;
using System.Data.OleDb;

namespace AeropuertoSofi
{
     partial class Form5 : Form
    {
        private Negocio minegocio;
        private String pasajeronumero;
        protected OleDbDataAdapter oda;
        protected OleDbConnection conexion;
        protected DataTable dt;

        public Form5(Negocio aux,String pasajer)
        {
            InitializeComponent();
            minegocio = aux;
            pasajeronumero = pasajer;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose(true);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AeropuertoSofi.accdb");
            conexion.Open();
            oda = new OleDbDataAdapter("Select * From Vuelos where Nombre='"+pasajeronumero+"'", conexion);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
      

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose(true);
        }
    }
}
