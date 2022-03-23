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
     partial class Form4 : Form
    {
        private Negocio minegocio;
        protected OleDbDataAdapter oda;
        protected OleDbConnection conexion;
        protected DataTable dt;


        public Form4(Negocio aux)
        {
            InitializeComponent();
            minegocio = aux;
        }
       

        private void Form4_Load(object sender, EventArgs e)
        {
            conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AeropuertoSofi.accdb");
            conexion.Open();
            oda =new OleDbDataAdapter("Select * From Vuelos", conexion);
            dt = new DataTable();
            oda.Fill(dt);     
            dataGridView1.DataSource = dt;
            



        }

       

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }
    }
}
