namespace WinFormsAppLogin
{
    partial class MenuRestrito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            CadastroMenu = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            janelasToolStripMenuItem = new ToolStripMenuItem();
            cascataToolStripMenuItem = new ToolStripMenuItem();
            organizarHorizontalmenteToolStripMenuItem = new ToolStripMenuItem();
            organizarVerticalmenteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            minimizarTodasToolStripMenuItem = new ToolStripMenuItem();
            maximizarTodasAsJanelasToolStripMenuItem = new ToolStripMenuItem();
            fecharTodasAsJanelasToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { CadastroMenu, janelasToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = janelasToolStripMenuItem;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // CadastroMenu
            // 
            CadastroMenu.DropDownItems.AddRange(new ToolStripItem[] { funcionárioToolStripMenuItem, clienteToolStripMenuItem });
            CadastroMenu.Name = "CadastroMenu";
            CadastroMenu.Size = new Size(82, 24);
            CadastroMenu.Text = "Cadastro";
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(169, 26);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            funcionárioToolStripMenuItem.Click += funcionárioToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(169, 26);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // janelasToolStripMenuItem
            // 
            janelasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascataToolStripMenuItem, organizarHorizontalmenteToolStripMenuItem, organizarVerticalmenteToolStripMenuItem, toolStripSeparator1, minimizarTodasToolStripMenuItem, maximizarTodasAsJanelasToolStripMenuItem, fecharTodasAsJanelasToolStripMenuItem, toolStripSeparator2 });
            janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            janelasToolStripMenuItem.Size = new Size(70, 24);
            janelasToolStripMenuItem.Text = "Janelas";
            janelasToolStripMenuItem.Click += janelasToolStripMenuItem_Click;
            // 
            // cascataToolStripMenuItem
            // 
            cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            cascataToolStripMenuItem.Size = new Size(274, 26);
            cascataToolStripMenuItem.Text = "Organizar em Cascata";
            cascataToolStripMenuItem.Click += cascataToolStripMenuItem_Click;
            // 
            // organizarHorizontalmenteToolStripMenuItem
            // 
            organizarHorizontalmenteToolStripMenuItem.Name = "organizarHorizontalmenteToolStripMenuItem";
            organizarHorizontalmenteToolStripMenuItem.Size = new Size(274, 26);
            organizarHorizontalmenteToolStripMenuItem.Text = "Organizar Horizontalmente";
            organizarHorizontalmenteToolStripMenuItem.Click += organizarHorizontalmenteToolStripMenuItem_Click;
            // 
            // organizarVerticalmenteToolStripMenuItem
            // 
            organizarVerticalmenteToolStripMenuItem.Name = "organizarVerticalmenteToolStripMenuItem";
            organizarVerticalmenteToolStripMenuItem.Size = new Size(274, 26);
            organizarVerticalmenteToolStripMenuItem.Text = "Organizar Verticalmente";
            organizarVerticalmenteToolStripMenuItem.Click += organizarVerticalmenteToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(271, 6);
            // 
            // minimizarTodasToolStripMenuItem
            // 
            minimizarTodasToolStripMenuItem.Name = "minimizarTodasToolStripMenuItem";
            minimizarTodasToolStripMenuItem.Size = new Size(274, 26);
            minimizarTodasToolStripMenuItem.Text = "Minimizar Todas as Janelas ";
            minimizarTodasToolStripMenuItem.Click += minimizarTodasToolStripMenuItem_Click;
            // 
            // maximizarTodasAsJanelasToolStripMenuItem
            // 
            maximizarTodasAsJanelasToolStripMenuItem.Name = "maximizarTodasAsJanelasToolStripMenuItem";
            maximizarTodasAsJanelasToolStripMenuItem.Size = new Size(274, 26);
            maximizarTodasAsJanelasToolStripMenuItem.Text = "Maximizar Todas as Janelas";
            maximizarTodasAsJanelasToolStripMenuItem.Click += maximizarTodasAsJanelasToolStripMenuItem_Click;
            // 
            // fecharTodasAsJanelasToolStripMenuItem
            // 
            fecharTodasAsJanelasToolStripMenuItem.Name = "fecharTodasAsJanelasToolStripMenuItem";
            fecharTodasAsJanelasToolStripMenuItem.Size = new Size(274, 26);
            fecharTodasAsJanelasToolStripMenuItem.Text = "Fechar Todas as Janelas";
            fecharTodasAsJanelasToolStripMenuItem.Click += fecharTodasAsJanelasToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(271, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // MenuRestrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuRestrito";
            Text = "MenuRestrito";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem CadastroMenu;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem janelasToolStripMenuItem;
        private ToolStripMenuItem cascataToolStripMenuItem;
        private ToolStripMenuItem organizarHorizontalmenteToolStripMenuItem;
        private ToolStripMenuItem organizarVerticalmenteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem minimizarTodasToolStripMenuItem;
        private ToolStripMenuItem fecharTodasAsJanelasToolStripMenuItem;
        private ToolStripMenuItem maximizarTodasAsJanelasToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
    }
}