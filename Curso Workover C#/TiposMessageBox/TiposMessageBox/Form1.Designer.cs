namespace TiposMessageBox
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
            groupBox1 = new GroupBox();
            btn_critico = new Button();
            btn_simnaocancelar = new Button();
            btn_simounao = new Button();
            btn_titulo = new Button();
            btn_simples = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(btn_critico);
            groupBox1.Controls.Add(btn_simnaocancelar);
            groupBox1.Controls.Add(btn_simounao);
            groupBox1.Controls.Add(btn_titulo);
            groupBox1.Controls.Add(btn_simples);
            groupBox1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(94, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 275);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipos de Alerta em C#";
            // 
            // btn_critico
            // 
            btn_critico.Cursor = Cursors.Hand;
            btn_critico.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            btn_critico.FlatStyle = FlatStyle.Popup;
            btn_critico.Location = new Point(18, 224);
            btn_critico.Name = "btn_critico";
            btn_critico.Size = new Size(231, 29);
            btn_critico.TabIndex = 4;
            btn_critico.Text = "Alerta com Ícone Crítico";
            btn_critico.UseVisualStyleBackColor = true;
            btn_critico.Click += btn_critico_Click;
            // 
            // btn_simnaocancelar
            // 
            btn_simnaocancelar.Cursor = Cursors.Hand;
            btn_simnaocancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            btn_simnaocancelar.FlatStyle = FlatStyle.Popup;
            btn_simnaocancelar.Location = new Point(18, 176);
            btn_simnaocancelar.Name = "btn_simnaocancelar";
            btn_simnaocancelar.Size = new Size(269, 29);
            btn_simnaocancelar.TabIndex = 3;
            btn_simnaocancelar.Text = "Alerta com Sim, Não e Cancelar";
            btn_simnaocancelar.UseVisualStyleBackColor = true;
            btn_simnaocancelar.Click += btn_simnaocancelar_Click;
            // 
            // btn_simounao
            // 
            btn_simounao.Cursor = Cursors.Hand;
            btn_simounao.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            btn_simounao.FlatStyle = FlatStyle.Popup;
            btn_simounao.Location = new Point(18, 130);
            btn_simounao.Name = "btn_simounao";
            btn_simounao.Size = new Size(224, 29);
            btn_simounao.TabIndex = 2;
            btn_simounao.Text = "Alerta com Sim ou Não";
            btn_simounao.UseVisualStyleBackColor = true;
            btn_simounao.Click += btn_simounao_Click;
            // 
            // btn_titulo
            // 
            btn_titulo.Cursor = Cursors.Hand;
            btn_titulo.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            btn_titulo.FlatStyle = FlatStyle.Popup;
            btn_titulo.Location = new Point(18, 84);
            btn_titulo.Name = "btn_titulo";
            btn_titulo.Size = new Size(224, 29);
            btn_titulo.TabIndex = 1;
            btn_titulo.Text = "Alerta Simples com Título";
            btn_titulo.UseVisualStyleBackColor = true;
            btn_titulo.Click += btn_titulo_Click;
            // 
            // btn_simples
            // 
            btn_simples.Cursor = Cursors.Hand;
            btn_simples.FlatAppearance.BorderColor = Color.Red;
            btn_simples.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            btn_simples.FlatStyle = FlatStyle.Popup;
            btn_simples.Location = new Point(18, 40);
            btn_simples.Name = "btn_simples";
            btn_simples.Size = new Size(137, 29);
            btn_simples.TabIndex = 0;
            btn_simples.Text = "Alerta Simples";
            btn_simples.UseVisualStyleBackColor = true;
            btn_simples.Click += btn_simples_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(492, 380);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Caixa de diálogo com o usuário";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_critico;
        private Button btn_simnaocancelar;
        private Button btn_simounao;
        private Button btn_titulo;
        private Button btn_simples;
    }
}
