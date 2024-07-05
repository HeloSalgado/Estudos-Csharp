namespace TiposMessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_simples_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá mundo!");
        }

        private void btn_titulo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá mundo!", "Título da Mensagem");
        }

        private void btn_simounao_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Vamos estudar C#!", "Título da Mensagem", MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                MessageBox.Show("Clicou em Sim");
            }
            else
            {
                MessageBox.Show("Clicou em Não");
            }
        }

        private void btn_simnaocancelar_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Tem +18?", "Eu tenho um ícone", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes) 
            {
                MessageBox.Show("Parabéns, vai trabalhar!");
            }
            else if (retorno == DialogResult.No)
            {
                MessageBox.Show("Vai tomar Toddynho!");
            }
        }

        private void btn_critico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ouviu o som do Windows?", "Sou um alerta crítico", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
