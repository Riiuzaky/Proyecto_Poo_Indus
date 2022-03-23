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
   
        partial class Form3 : Form
    {
        private Negocio minegocio;
        private int aa;
        

         public Form3(Negocio aux)
        {
            InitializeComponent();
            this.minegocio = aux;
            this.aa = 0;
        }

      
       

        private void cmbdestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Btnvender_Click(object sender, EventArgs e)
        {
            if (cmbdestino.SelectedIndex == 0)
            {
                aa = 0;
                aa = aa + 1200000;
                if (comboBox1.SelectedIndex == 0)
                {

                    aa = aa + 250000;
                    if (comboBox2.SelectedIndex == 0)
                    {

                        aa = aa + 100000;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {

                        aa = aa + 80000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {

                        aa = aa + 50000;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {

                        aa = aa + 0;
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {

                    aa = aa + 200000;
                    if (comboBox2.SelectedIndex == 0)
                    {

                        aa = aa + 100000;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {

                        aa = aa + 80000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {

                        aa = aa + 50000;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {

                        aa = aa + 0;
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {

                    aa = aa + 150000;
                    if (comboBox2.SelectedIndex == 0)
                    {

                        aa = aa + 100000;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {

                        aa = aa + 80000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {

                        aa = aa + 50000;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {

                        aa = aa + 0;
                    }
                }
                else if (comboBox1.SelectedIndex == 3)
                {

                    aa = aa + 0;
                    if (comboBox2.SelectedIndex == 0)
                    {

                        aa = aa + 100000;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {

                        aa = aa + 80000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {

                        aa = aa + 50000;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {

                        aa = aa + 0;
                    }
                }
            }
            else if (cmbdestino.SelectedIndex == 1)
            {
                aa = 0;
                aa = aa + 1500000;
                if (comboBox1.SelectedIndex == 0)
                {

                    aa = aa + 250000;
                    if (comboBox2.SelectedIndex == 0)
                    {

                        aa = aa + 100000;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {

                        aa = aa + 80000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {

                        aa = aa + 50000;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {

                        aa = aa + 0;
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {

                    aa = aa + 200000;
                    if (comboBox2.SelectedIndex == 0)
                    {

                        aa = aa + 100000;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {

                        aa = aa + 80000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {

                        aa = aa + 50000;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {

                        aa = aa + 0;
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {

                    aa = aa + 150000;
                    if (comboBox2.SelectedIndex == 0)
                    {

                        aa = aa + 100000;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {

                        aa = aa + 80000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {

                        aa = aa + 50000;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {

                        aa = aa + 0;
                    }
                }
                else if (comboBox1.SelectedIndex == 3)
                {

                    aa = aa + 0;
                    if (comboBox2.SelectedIndex == 0)
                    {

                        aa = aa + 100000;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {

                        aa = aa + 80000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {

                        aa = aa + 50000;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {

                        aa = aa + 0;
                    }
                }
            }
            else if (cmbdestino.SelectedIndex == 2)
            {
                aa = 0;
                aa = aa + 1800000;
                if (comboBox1.SelectedIndex == 0)
                {

                    aa = aa + 250000;
                    if (comboBox2.SelectedIndex == 0)
                    {

                        aa = aa + 100000;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {

                        aa = aa + 80000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {

                        aa = aa + 50000;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {

                        aa = aa + 0;
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {

                    aa = aa + 200000;
                    if (comboBox2.SelectedIndex == 0)
                    {

                        aa = aa + 100000;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {

                        aa = aa + 80000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {

                        aa = aa + 50000;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {

                        aa = aa + 0;
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {

                    aa = aa + 150000;
                    if (comboBox2.SelectedIndex == 0)
                    {

                        aa = aa + 100000;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {

                        aa = aa + 80000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {

                        aa = aa + 50000;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {

                        aa = aa + 0;
                    }
                }
                else if (comboBox1.SelectedIndex == 3)
                {

                    aa = aa + 0;
                    if (comboBox2.SelectedIndex == 0)
                    {

                        aa = aa + 100000;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {

                        aa = aa + 80000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {

                        aa = aa + 50000;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {

                        aa = aa + 0;
                    }
                }
            }
            else if (cmbdestino.SelectedIndex == 3)
            {
                aa = 0;
                aa = aa + 2000000;
                if (comboBox1.SelectedIndex == 0)
                {

                    aa = aa + 250000;
                    if (comboBox2.SelectedIndex == 0)
                    {

                        aa = aa + 100000;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {

                        aa = aa + 80000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {

                        aa = aa + 50000;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {

                        aa = aa + 0;
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {

                    aa = aa + 200000;
                    if (comboBox2.SelectedIndex == 0)
                    {

                        aa = aa + 100000;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {

                        aa = aa + 80000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {

                        aa = aa + 50000;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {

                        aa = aa + 0;
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {

                    aa = aa + 150000;
                    if (comboBox2.SelectedIndex == 0)
                    {

                        aa = aa + 100000;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {

                        aa = aa + 80000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {

                        aa = aa + 50000;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {

                        aa = aa + 0;
                    }
                }
                else if (comboBox1.SelectedIndex == 3)
                {

                    aa = aa + 0;
                    if (comboBox2.SelectedIndex == 0)
                    {

                        aa = aa + 100000;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {

                        aa = aa + 80000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {

                        aa = aa + 50000;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {

                        aa = aa + 0;

                    }
                }
            }












            if (cmbdestino.SelectedIndex < 0 || cmbdestino.SelectedIndex > 3 || dateTimePicker1.Text == ""  || comboBox2.SelectedIndex < 0 || comboBox2.SelectedIndex > 3 || comboBox1.SelectedIndex < 0 || comboBox1.SelectedIndex > 3)
            {
                MessageBox.Show("Porfavor ingrese todos los datos!!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Aerolinea.Vuelo mivuelo = new Aerolinea.Vuelo();

                mivuelo.DES = cmbdestino.Text;
                mivuelo.FEC = dateTimePicker1.Value;
                mivuelo.CLAS = comboBox1.Text;
                mivuelo.MEN = comboBox2.Text;

                DialogResult res = MessageBox.Show("Esta seguro de Almacenar la fifura asi como esta configurada ¿si / no?", "Mensaje de confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    minegocio.VU.Add(mivuelo);
                    Form registrarpasajero = new Form6(minegocio, mivuelo, aa);
                    registrarpasajero.ShowDialog();
                    this.Dispose(true);
                }
                else
                {
                    this.Dispose(true);
                }
            }
        }

        private void cmbdestino_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
