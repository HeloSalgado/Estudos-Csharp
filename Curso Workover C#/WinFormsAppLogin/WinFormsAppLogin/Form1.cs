namespace WinFormsAppLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Deseja realmente fechar a janela? Todas as alterações feitas serão perdidas.", "Confirmação de cancelamento", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (retorno == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_usuario.Text.Equals("helosalgado") && txt_senha.Text.Equals("helo123"))
                {
                    var menu = new MenuRestrito();
                    menu.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário e/ou Senha inválidos.",
                                    "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    txt_usuario.Focus();
                    txt_senha.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            txt_usuario.BackColor = Color.LightBlue;
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            txt_usuario.BackColor = Color.White;
        }

        private void txt_senha_Enter(object sender, EventArgs e)
        {
            txt_senha.BackColor = Color.LightBlue;
        }

        private void txt_senha_Leave(object sender, EventArgs e)
        {
            txt_senha.BackColor = Color.White;
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = Convert.ToInt32(e.KeyChar);

            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 08)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras ou números",
                                    "Ops",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                txt_usuario.SelectionStart = 0;
                txt_usuario.SelectionLength = txt_usuario.Text.Length;
            }
        }
    }
}
