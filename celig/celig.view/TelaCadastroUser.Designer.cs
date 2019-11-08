namespace celig.view
{
    partial class TelaCadastroUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNomeUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.TxtSenhaUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.TxtConfirmarSenhaCadastro = new System.Windows.Forms.TextBox();
            this.BtnTelaCadastrarUser = new System.Windows.Forms.Button();
            this.BtnVoltarUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar Senha:";
            // 
            // TxtNomeUsuarioCadastro
            // 
            this.TxtNomeUsuarioCadastro.Location = new System.Drawing.Point(118, 70);
            this.TxtNomeUsuarioCadastro.Name = "TxtNomeUsuarioCadastro";
            this.TxtNomeUsuarioCadastro.Size = new System.Drawing.Size(209, 20);
            this.TxtNomeUsuarioCadastro.TabIndex = 3;
            // 
            // TxtSenhaUsuarioCadastro
            // 
            this.TxtSenhaUsuarioCadastro.Location = new System.Drawing.Point(118, 116);
            this.TxtSenhaUsuarioCadastro.Name = "TxtSenhaUsuarioCadastro";
            this.TxtSenhaUsuarioCadastro.Size = new System.Drawing.Size(209, 20);
            this.TxtSenhaUsuarioCadastro.TabIndex = 4;
            // 
            // TxtConfirmarSenhaCadastro
            // 
            this.TxtConfirmarSenhaCadastro.Location = new System.Drawing.Point(118, 167);
            this.TxtConfirmarSenhaCadastro.Name = "TxtConfirmarSenhaCadastro";
            this.TxtConfirmarSenhaCadastro.Size = new System.Drawing.Size(209, 20);
            this.TxtConfirmarSenhaCadastro.TabIndex = 5;
            // 
            // BtnTelaCadastrarUser
            // 
            this.BtnTelaCadastrarUser.BackColor = System.Drawing.Color.White;
            this.BtnTelaCadastrarUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTelaCadastrarUser.Location = new System.Drawing.Point(172, 209);
            this.BtnTelaCadastrarUser.Name = "BtnTelaCadastrarUser";
            this.BtnTelaCadastrarUser.Size = new System.Drawing.Size(99, 23);
            this.BtnTelaCadastrarUser.TabIndex = 6;
            this.BtnTelaCadastrarUser.Text = "Cadastrar";
            this.BtnTelaCadastrarUser.UseVisualStyleBackColor = false;
            // 
            // BtnVoltarUser
            // 
            this.BtnVoltarUser.BackColor = System.Drawing.Color.White;
            this.BtnVoltarUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltarUser.Location = new System.Drawing.Point(12, 228);
            this.BtnVoltarUser.Name = "BtnVoltarUser";
            this.BtnVoltarUser.Size = new System.Drawing.Size(58, 22);
            this.BtnVoltarUser.TabIndex = 7;
            this.BtnVoltarUser.Text = "Voltar";
            this.BtnVoltarUser.UseVisualStyleBackColor = false;
            // 
            // TelaCadastroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(462, 262);
            this.Controls.Add(this.BtnVoltarUser);
            this.Controls.Add(this.BtnTelaCadastrarUser);
            this.Controls.Add(this.TxtConfirmarSenhaCadastro);
            this.Controls.Add(this.TxtSenhaUsuarioCadastro);
            this.Controls.Add(this.TxtNomeUsuarioCadastro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroUser";
            this.Text = "TelaCadastroUser";
            this.Load += new System.EventHandler(this.TelaCadastroUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNomeUsuarioCadastro;
        private System.Windows.Forms.TextBox TxtSenhaUsuarioCadastro;
        private System.Windows.Forms.TextBox TxtConfirmarSenhaCadastro;
        private System.Windows.Forms.Button BtnTelaCadastrarUser;
        private System.Windows.Forms.Button BtnVoltarUser;
    }
}