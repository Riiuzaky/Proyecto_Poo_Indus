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
   
    public partial class Form2 : Form
    {
        
        private Negocio minegocio;
        protected OleDbConnection connection;
        protected OleDbCommand comando = new OleDbCommand();
        protected OleDbDataAdapter oda;
        protected DataTable dt;

        public Form2()
        {
            InitializeComponent();
            minegocio = new Negocio();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                
                connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AeropuertoSofi.accdb");
                connection.Open();
               
                

                



            }
            catch (Exception)
            {

                MessageBox.Show("No Se establecio Conexion");
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form reporte = new Form4(minegocio);
            reporte.ShowDialog();
        }
  

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnvender_Click_1(object sender, EventArgs e)
        {
            Form registrarvuelo = new Form3(minegocio);
            registrarvuelo.ShowDialog();
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form mireporte = new Form5(minegocio, comboBox2.GetItemText(comboBox2.SelectedItem));
            mireporte.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form reporte = new Form4(minegocio);
            reporte.ShowDialog();
        }

        private void comboBox2_MouseDown(object sender, MouseEventArgs e)
        {
            oda = new OleDbDataAdapter("SELECT DISTINCT Nombre from Vuelos", connection);
            dt = new DataTable();
            oda.Fill(dt);

            comboBox2.Items.Clear();
            DataRow dr = dt.NewRow();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i]["Nombre"].ToString());
            }
        }
    }
}
