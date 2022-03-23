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
     partial class Form7 : Form
    {
        private Negocio minegocio;
        private Vuelo mivuelo;
        private Pasajero mipasajero;
        private int aa;
        protected OleDbCommand comando = new OleDbCommand();
        protected OleDbConnection conexion;
        public Form7(Negocio aux, Vuelo vuel, Pasajero pas, int aaa)
        {
            InitializeComponent();
            minegocio = aux;
            mivuelo = vuel;
            mipasajero = pas;
            aa = aaa;
            textBox1.Text = "0";

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AeropuertoSofi.accdb");
            conexion.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            minegocio.Pasa.Remove(mipasajero);
            minegocio.VU.Remove(mivuelo);
            this.Dispose(true);
        }

        private void Btnvender_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                aa = aa + 50000;
                if (comboBox2.SelectedIndex == 0)
                {
                    aa = aa + 10000;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    aa = aa + 0;
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                aa = aa + 80000;
                if (comboBox2.SelectedIndex == 0)
                {
                    aa = aa + 20000;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    aa = aa + 0;
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                aa = aa + 0;
                if (comboBox2.SelectedIndex == 0)
                {
                    aa = aa + 5000;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    aa = aa + 0;
                }
            }











            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0 || long.Parse(textBox1.Text) < 0)
            {
                MessageBox.Show("Porfavor ingrese todos los datos!!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Aerolinea.Equipaje miequipaje = new Aerolinea.Equipaje();
                miequipaje.TIP0 = comboBox1.Text;
                miequipaje.SELLAD = comboBox2.Text;
                miequipaje.DINER = long.Parse(textBox1.Text);
                miequipaje.DINER2 = long.Parse(textBox1.Text);
                miequipaje.PAGR = aa;
                miequipaje.calculardinero();
                if (miequipaje.DINER > 0)
                {
                    DialogResult res2 = MessageBox.Show("Usted no Puede Viajar con mas de 5 MILLONES De Pesos");
                    textBox1.Text = "";
                }
                else
                {
                    DialogResult res = MessageBox.Show("Esta seguro de Comprar el Ticket ¿si / no?", "Mensaje de confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        minegocio.EQUI.Add(miequipaje);
                        comando.Connection = conexion;
                        comando.CommandText = "INSERT INTO Vuelos(Nombre,Documento,Pasaporte,Vuelo,Fecha,Clase,Menu,Precio) VALUES ('"+mipasajero.COMP+ "','" + mipasajero.DOC + "','" + mipasajero.PASAP + "','" + mivuelo.DES + "','" + mivuelo.FEC+ "','" + mivuelo.CLAS + "','" + mivuelo.MEN + "','" + miequipaje.PAGR + "')";
                        comando.ExecuteNonQuery();
                        conexion.Close();                       
                        this.Dispose(true);
                        
                    }
                    else
                    {

                    }
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten letras");
            }
            else
            {
                if (char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    if (char.IsNumber(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                }
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten letras ni Numeros, Porfavor Seleccione una de las opciones");
            }
            else
            {
                if (char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("No se permiten letras ni Numeros, Porfavor Seleccione una de las opciones");
                }
                else
                {
                    if (char.IsNumber(e.KeyChar))
                    {
                        e.Handled = true;
                        MessageBox.Show("No se permiten letras ni Numeros, Porfavor Seleccione una de las opciones");
                    }
                }
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten letras ni Numeros, Porfavor Seleccione una de las opciones");
            }
            else
            {
                if (char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("No se permiten letras ni Numeros, Porfavor Seleccione una de las opciones");
                }
                else
                {
                    if (char.IsNumber(e.KeyChar))
                    {
                        e.Handled = true;
                        MessageBox.Show("No se permiten letras ni Numeros, Porfavor Seleccione una de las opciones");
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
