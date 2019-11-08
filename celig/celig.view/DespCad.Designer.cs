namespace celig.view
{
    partial class DespCad
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
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.CBCad = new System.Windows.Forms.ComboBox();
            this.btnCategoriaCad = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(135, 67);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(235, 20);
            this.TxtValor.TabIndex = 0;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(135, 119);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(235, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // CBCad
            // 
            this.CBCad.FormattingEnabled = true;
            this.CBCad.Location = new System.Drawing.Point(135, 168);
            this.CBCad.Name = "CBCad";
            this.CBCad.Size = new System.Drawing.Size(235, 21);
            this.CBCad.TabIndex = 2;
            // 
            // btnCategoriaCad
            // 
            this.btnCategoriaCad.Location = new System.Drawing.Point(388, 168);
            this.btnCategoriaCad.Name = "btnCategoriaCad";
            this.btnCategoriaCad.Size = new System.Drawing.Size(154, 21);
            this.btnCategoriaCad.TabIndex = 3;
            this.btnCategoriaCad.Text = "Cadastrar Nova Categoria";
            this.btnCategoriaCad.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(184, 234);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(142, 75);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // DespCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 422);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnCategoriaCad);
            this.Controls.Add(this.CBCad);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.TxtValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DespCad";
            this.Text = "DespCad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox CBCad;
        private System.Windows.Forms.Button btnCategoriaCad;
        private System.Windows.Forms.Button btnCadastrar;
    }
}