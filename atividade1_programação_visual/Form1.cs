namespace atividade1_programação_visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Evento executado quando o botão é clicado
        private void btnSaudacao_Click(object sender, EventArgs e)
        {   

            //Captura o nome digitado pelo usuario
            String nomeUsuario = txtNome.Text;

            //Verifica se o usuario digitou seu nome
            if (nomeUsuario == "")

            {
                MessageBox.Show("Por favor, digite seu nome.");
            }
            else

                MessageBox.Show("Olá " + nomeUsuario + "! Seja bem-vindo ao sistema");
        }
    }
}
