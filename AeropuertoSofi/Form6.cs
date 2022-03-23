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

namespace AeropuertoSofi
{
     partial class Form6 : Form
    {
        private Negocio minegocio;
        private Vuelo mivuelo;
        private int aaa;
        public Form6(Negocio aux, Vuelo vuel,int aa)
        {
            InitializeComponent();
            minegocio = aux;
            mivuelo = vuel;
            aaa = aa;
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Btnvender_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || long.Parse(textBox3.Text) == 0 || long.Parse(textBox4.Text) == 0 || long.Parse(textBox5.Text) == 0 || long.Parse(textBox6.Text) == 0)
            {
                MessageBox.Show("Porfavor ingrese todos los datos!!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Aerolinea.Pasajero mipasajero = new Aerolinea.Pasajero();
                mipasajero.COMP = textBox1.Text;
                mipasajero.DIRECC = textBox2.Text;
                mipasajero.DOC = long.Parse(textBox3.Text);
                mipasajero.EDAD = long.Parse(textBox4.Text);
                mipasajero.PASAP = long.Parse(textBox5.Text);
                mipasajero.EXPE = long.Parse(textBox6.Text);
                mipasajero.calcularexpedicion();
                if (mipasajero.EXPE < 0 || mipasajero.EXPE > 5)
                {
                    DialogResult res2 = MessageBox.Show("Su Pasaporte Ya Expiro , Lo sentimos no puede viajar");

                }
                else
                {
                    DialogResult res = MessageBox.Show("Esta seguro de Almacenar la fifura asi como esta configurada ¿si / no?", "Mensaje de confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        minegocio.Pasa.Add(mipasajero);
                        Form registrarequipaje = new Form7(minegocio, mivuelo, mipasajero, aaa);
                        registrarequipaje.ShowDialog();
                        this.Dispose(true);
                    }
                    else
                    {

                    }

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            minegocio.VU.Remove(mivuelo);
            this.Dispose(true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten numeros");
            }
            else
            {
                if (char.IsSymbol(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("No se permiten Symbolos");
                }
                else
                {
                    if (char.IsPunctuation(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                
            }
            else
            {
                if (char.IsSymbol(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("No se permiten Symbolos");
                }
                else
                {
                    if (char.IsPunctuation(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
