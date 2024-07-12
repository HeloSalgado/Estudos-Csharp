namespace WinFormsAppLogin
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
            btn_entrar = new Button();
            btn_cancelar = new Button();
            label2 = new Label();
            txt_senha = new TextBox();
            txt_usuario = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_entrar);
            groupBox1.Controls.Add(btn_cancelar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_senha);
            groupBox1.Controls.Add(txt_usuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(30, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(545, 313);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulário de Login";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btn_entrar
            // 
            btn_entrar.Location = new Point(435, 263);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(94, 39);
            btn_entrar.TabIndex = 5;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = true;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(312, 263);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(107, 39);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 184);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // txt_senha
            // 
            txt_senha.BorderStyle = BorderStyle.FixedSingle;
            txt_senha.Location = new Point(118, 181);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(387, 34);
            txt_senha.TabIndex = 2;
            txt_senha.UseSystemPasswordChar = true;
            txt_senha.Enter += txt_senha_Enter;
            txt_senha.Leave += txt_senha_Leave;
            // 
            // txt_usuario
            // 
            txt_usuario.BorderStyle = BorderStyle.FixedSingle;
            txt_usuario.CharacterCasing = CharacterCasing.Lower;
            txt_usuario.Location = new Point(118, 91);
            txt_usuario.MaxLength = 30;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.PlaceholderText = "Apenas letras ou números ";
            txt_usuario.Size = new Size(387, 34);
            txt_usuario.TabIndex = 1;
            txt_usuario.Enter += txt_usuario_Enter;
            txt_usuario.KeyPress += txt_usuario_KeyPress;
            txt_usuario.Leave += txt_usuario_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 91);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 363);
            ControlBox = false;
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISGEN - Sistema de Gestão";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_entrar;
        private Button btn_cancelar;
        private Label label2;
        private TextBox txt_senha;
        private TextBox txt_usuario;
        private Label label1;
    }
}
