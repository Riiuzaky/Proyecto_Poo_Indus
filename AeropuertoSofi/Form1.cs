namespace AeropuertoSofi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtcontraseña.PasswordChar = Convert.ToChar("*");
            txtcontraseña.MaxLength = 10;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btniniciar_Click_1(object sender, EventArgs e)
        {
            if ((txtusuario.Text != "") && (txtcontraseña.Text != ""))
            {
                if (txtcontraseña.Text == "1234")
                {
                    if (txtusuario.Text == "Sofi")
                    {
                        this.Hide();
                        Form principal = new Form2();
                        principal.Show();



                    }
                    else
                    {
                        MessageBox.Show("Contraseña o Usuario incorrecto, porfavor intente de nuevo");
                        txtcontraseña.Text = "";
                        txtusuario.Text = "";
                    }
                    txtcontraseña.Visible = true;
                }
                else
                {
                    MessageBox.Show("Contraseña o Usuario incorrecto, porfavor intente de nuevo");
                    txtcontraseña.Text = "";
                    txtusuario.Text = "";
                    txtcontraseña.Visible = true;
                }

            }
        }

        private void Btncancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }

}