namespace ProjetoAtendimento.Views
{
    partial class Atendimento
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
            this.lbxSenhas = new System.Windows.Forms.ListBox();
            this.lbxSenhasGuiche = new System.Windows.Forms.ListBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnChamar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnListarSenhas = new System.Windows.Forms.Button();
            this.btnListarAtend = new System.Windows.Forms.Button();
            this.lblNumGuiche = new System.Windows.Forms.Label();
            this.lblQtdeGuiche = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuiche = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxSenhas
            // 
            this.lbxSenhas.FormattingEnabled = true;
            this.lbxSenhas.Location = new System.Drawing.Point(26, 59);
            this.lbxSenhas.Name = "lbxSenhas";
            this.lbxSenhas.Size = new System.Drawing.Size(217, 264);
            this.lbxSenhas.TabIndex = 0;
            // 
            // lbxSenhasGuiche
            // 
            this.lbxSenhasGuiche.FormattingEnabled = true;
            this.lbxSenhasGuiche.Location = new System.Drawing.Point(390, 59);
            this.lbxSenhasGuiche.Name = "lbxSenhasGuiche";
            this.lbxSenhasGuiche.Size = new System.Drawing.Size(381, 264);
            this.lbxSenhasGuiche.TabIndex = 1;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(92, 30);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnChamar
            // 
            this.btnChamar.Location = new System.Drawing.Point(665, 30);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(75, 23);
            this.btnChamar.TabIndex = 3;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            this.btnChamar.Click += new System.EventHandler(this.btnChamar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(273, 231);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnListarSenhas
            // 
            this.btnListarSenhas.Location = new System.Drawing.Point(82, 329);
            this.btnListarSenhas.Name = "btnListarSenhas";
            this.btnListarSenhas.Size = new System.Drawing.Size(94, 23);
            this.btnListarSenhas.TabIndex = 5;
            this.btnListarSenhas.Text = "Listar Senhas";
            this.btnListarSenhas.UseVisualStyleBackColor = true;
            this.btnListarSenhas.Click += new System.EventHandler(this.btnListarSenhas_Click);
            // 
            // btnListarAtend
            // 
            this.btnListarAtend.Location = new System.Drawing.Point(523, 329);
            this.btnListarAtend.Name = "btnListarAtend";
            this.btnListarAtend.Size = new System.Drawing.Size(136, 23);
            this.btnListarAtend.TabIndex = 6;
            this.btnListarAtend.Text = "Listar Atendimentos";
            this.btnListarAtend.UseVisualStyleBackColor = true;
            this.btnListarAtend.Click += new System.EventHandler(this.btnListarAtend_Click);
            // 
            // lblNumGuiche
            // 
            this.lblNumGuiche.AutoSize = true;
            this.lblNumGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumGuiche.Location = new System.Drawing.Point(296, 187);
            this.lblNumGuiche.Name = "lblNumGuiche";
            this.lblNumGuiche.Size = new System.Drawing.Size(30, 31);
            this.lblNumGuiche.TabIndex = 7;
            this.lblNumGuiche.Text = "0";
            // 
            // lblQtdeGuiche
            // 
            this.lblQtdeGuiche.AutoSize = true;
            this.lblQtdeGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeGuiche.Location = new System.Drawing.Point(270, 152);
            this.lblQtdeGuiche.Name = "lblQtdeGuiche";
            this.lblQtdeGuiche.Size = new System.Drawing.Size(90, 16);
            this.lblQtdeGuiche.TabIndex = 8;
            this.lblQtdeGuiche.Text = "Qtde guichês:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Guichê:";
            // 
            // txtGuiche
            // 
            this.txtGuiche.Location = new System.Drawing.Point(541, 32);
            this.txtGuiche.Name = "txtGuiche";
            this.txtGuiche.Size = new System.Drawing.Size(100, 20);
            this.txtGuiche.TabIndex = 10;
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 379);
            this.Controls.Add(this.txtGuiche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQtdeGuiche);
            this.Controls.Add(this.lblNumGuiche);
            this.Controls.Add(this.btnListarAtend);
            this.Controls.Add(this.btnListarSenhas);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lbxSenhasGuiche);
            this.Controls.Add(this.lbxSenhas);
            this.Name = "Atendimento";
            this.Text = "Atendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSenhas;
        private System.Windows.Forms.ListBox lbxSenhasGuiche;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnListarSenhas;
        private System.Windows.Forms.Button btnListarAtend;
        private System.Windows.Forms.Label lblNumGuiche;
        private System.Windows.Forms.Label lblQtdeGuiche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuiche;
    }
}