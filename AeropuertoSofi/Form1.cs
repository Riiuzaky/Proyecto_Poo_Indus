namespace AeropuertoSofi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtcontrase�a.PasswordChar = Convert.ToChar("*");
            txtcontrase�a.MaxLength = 10;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btniniciar_Click_1(object sender, EventArgs e)
        {
            if ((txtusuario.Text != "") && (txtcontrase�a.Text != ""))
            {
                if (txtcontrase�a.Text == "1234")
                {
                    if (txtusuario.Text == "Sofi")
                    {
                        this.Hide();
                        Form principal = new Form2();
                        principal.Show();



                    }
                    else
                    {
                        MessageBox.Show("Contrase�a o Usuario incorrecto, porfavor intente de nuevo");
                        txtcontrase�a.Text = "";
                        txtusuario.Text = "";
                    }
                    txtcontrase�a.Visible = true;
                }
                else
                {
                    MessageBox.Show("Contrase�a o Usuario incorrecto, porfavor intente de nuevo");
                    txtcontrase�a.Text = "";
                    txtusuario.Text = "";
                    txtcontrase�a.Visible = true;
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

        private void txtcontrase�a_TextChanged(object sender, EventArgs e)
        {

        }
    }

}