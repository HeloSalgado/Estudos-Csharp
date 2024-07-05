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
            MessageBox.Show("Ol� mundo!");
        }

        private void btn_titulo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ol� mundo!", "T�tulo da Mensagem");
        }

        private void btn_simounao_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Vamos estudar C#!", "T�tulo da Mensagem", MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                MessageBox.Show("Clicou em Sim");
            }
            else
            {
                MessageBox.Show("Clicou em N�o");
            }
        }

        private void btn_simnaocancelar_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Tem +18?", "Eu tenho um �cone", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes) 
            {
                MessageBox.Show("Parab�ns, vai trabalhar!");
            }
            else if (retorno == DialogResult.No)
            {
                MessageBox.Show("Vai tomar Toddynho!");
            }
        }

        private void btn_critico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ouviu o som do Windows?", "Sou um alerta cr�tico", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
