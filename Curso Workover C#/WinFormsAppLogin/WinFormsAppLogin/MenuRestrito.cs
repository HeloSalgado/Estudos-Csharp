using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLogin
{
    public partial class MenuRestrito : Form
    {
        public MenuRestrito()
        {
            InitializeComponent();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form janelaCadastro = new CadastroFuncionario();
            janelaCadastro.MdiParent = this;
            janelaCadastro.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void organizarHorizontalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void organizarVerticalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

        }

        private void minimizarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var j in this.MdiChildren)
            {
                j.WindowState = FormWindowState.Minimized;
            }
        }

        private void fecharTodasAsJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var j in this.MdiChildren)
            {
                j.Close();
            }
        }

        private void maximizarTodasAsJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var j in this.MdiChildren)
            {
                j.WindowState = FormWindowState.Maximized;
            }
        }

        private void janelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                this.toolStripSeparator2.Visible = false;
            } 
            else
            {
                this.toolStripSeparator2.Visible = true;
            }
        }
    }
}
