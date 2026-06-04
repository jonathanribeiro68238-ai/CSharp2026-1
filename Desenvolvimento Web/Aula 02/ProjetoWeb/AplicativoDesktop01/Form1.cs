namespace AplicativoDesktop01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = "Ronaldo";
            string senha = "123456";

            bool comparacao1 = textBox1.Text == usuario;
            bool comparacao2 = textBox2.Text == senha;

            if (comparacao1 & comparacao2)
            {
                MessageBox.Show("Usuario e senha corretos!");
            }

            else
            {
                MessageBox.Show("Usuario ou senha incorretos");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
