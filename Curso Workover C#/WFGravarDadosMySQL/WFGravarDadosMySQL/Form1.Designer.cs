namespace WFGravarDadosMySQL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_nome = new TextBox();
            txt_email = new TextBox();
            txt_telefone = new TextBox();
            btn_salvar = new Button();
            lst_contatos = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            excluirToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            txt_busca = new TextBox();
            btn_buscar = new Button();
            button1 = new Button();
            btn_excluir = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 42);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 115);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 202);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(46, 74);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(259, 27);
            txt_nome.TabIndex = 3;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(46, 153);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(259, 27);
            txt_email.TabIndex = 4;
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(46, 235);
            txt_telefone.MaxLength = 11;
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(259, 27);
            txt_telefone.TabIndex = 5;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(225, 279);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(80, 29);
            btn_salvar.TabIndex = 6;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // lst_contatos
            // 
            lst_contatos.AllowColumnReorder = true;
            lst_contatos.ContextMenuStrip = contextMenuStrip1;
            lst_contatos.FullRowSelect = true;
            lst_contatos.GridLines = true;
            lst_contatos.LabelEdit = true;
            lst_contatos.Location = new Point(352, 109);
            lst_contatos.MultiSelect = false;
            lst_contatos.Name = "lst_contatos";
            lst_contatos.Size = new Size(575, 381);
            lst_contatos.TabIndex = 7;
            lst_contatos.UseCompatibleStateImageBehavior = false;
            lst_contatos.View = View.Details;
            lst_contatos.ItemSelectionChanged += lst_contatos_ItemSelectionChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { excluirToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(179, 28);
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.Size = new Size(178, 24);
            excluirToolStripMenuItem.Text = "Excluir Contato";
            excluirToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 42);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 8;
            label4.Text = "Buscar Contato";
            // 
            // txt_busca
            // 
            txt_busca.Location = new Point(352, 74);
            txt_busca.Name = "txt_busca";
            txt_busca.Size = new Size(426, 27);
            txt_busca.TabIndex = 9;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(784, 74);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(143, 29);
            btn_buscar.TabIndex = 10;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(46, 279);
            button1.Name = "button1";
            button1.Size = new Size(78, 29);
            button1.TabIndex = 11;
            button1.Text = "Novo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(138, 279);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(72, 29);
            btn_excluir.TabIndex = 12;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Visible = false;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 516);
            Controls.Add(btn_excluir);
            Controls.Add(button1);
            Controls.Add(btn_buscar);
            Controls.Add(txt_busca);
            Controls.Add(label4);
            Controls.Add(lst_contatos);
            Controls.Add(btn_salvar);
            Controls.Add(txt_telefone);
            Controls.Add(txt_email);
            Controls.Add(txt_nome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_nome;
        private TextBox txt_email;
        private TextBox txt_telefone;
        private Button btn_salvar;
        private ListView lst_contatos;
        private Label label4;
        private TextBox txt_busca;
        private Button btn_buscar;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private Button button1;
        private Button btn_excluir;
    }
}
