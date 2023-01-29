namespace AlocacaoDesenvolvedorTrabalho
{
    partial class JanelaProjeto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFimProjeto = new System.Windows.Forms.DateTimePicker();
            this.dtpPrevisaoProjeto = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioProjeto = new System.Windows.Forms.DateTimePicker();
            this.bntSalvarProjeto = new System.Windows.Forms.Button();
            this.txtProjeto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpFimProjeto);
            this.panel1.Controls.Add(this.dtpPrevisaoProjeto);
            this.panel1.Controls.Add(this.dtpInicioProjeto);
            this.panel1.Controls.Add(this.bntSalvarProjeto);
            this.panel1.Controls.Add(this.txtProjeto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 229);
            this.panel1.TabIndex = 1;
            // 
            // dtpFimProjeto
            // 
            this.dtpFimProjeto.Location = new System.Drawing.Point(123, 164);
            this.dtpFimProjeto.Name = "dtpFimProjeto";
            this.dtpFimProjeto.Size = new System.Drawing.Size(200, 20);
            this.dtpFimProjeto.TabIndex = 9;
            // 
            // dtpPrevisaoProjeto
            // 
            this.dtpPrevisaoProjeto.Location = new System.Drawing.Point(135, 138);
            this.dtpPrevisaoProjeto.Name = "dtpPrevisaoProjeto";
            this.dtpPrevisaoProjeto.Size = new System.Drawing.Size(200, 20);
            this.dtpPrevisaoProjeto.TabIndex = 8;
            // 
            // dtpInicioProjeto
            // 
            this.dtpInicioProjeto.Location = new System.Drawing.Point(78, 105);
            this.dtpInicioProjeto.Name = "dtpInicioProjeto";
            this.dtpInicioProjeto.Size = new System.Drawing.Size(210, 20);
            this.dtpInicioProjeto.TabIndex = 7;
            // 
            // bntSalvarProjeto
            // 
            this.bntSalvarProjeto.Location = new System.Drawing.Point(6, 196);
            this.bntSalvarProjeto.Name = "bntSalvarProjeto";
            this.bntSalvarProjeto.Size = new System.Drawing.Size(118, 23);
            this.bntSalvarProjeto.TabIndex = 6;
            this.bntSalvarProjeto.Text = "Salvar Novo Projeto";
            this.bntSalvarProjeto.UseVisualStyleBackColor = true;
            this.bntSalvarProjeto.Click += new System.EventHandler(this.bntSalvarProjeto_Click);
            // 
            // txtProjeto
            // 
            this.txtProjeto.Location = new System.Drawing.Point(98, 76);
            this.txtProjeto.Name = "txtProjeto";
            this.txtProjeto.Size = new System.Drawing.Size(100, 20);
            this.txtProjeto.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Projeto acabou? Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Prevista para Acabar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Início:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Projeto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo Projeto";
            // 
            // JanelaProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 238);
            this.Controls.Add(this.panel1);
            this.Name = "JanelaProjeto";
            this.Text = "JanelaProjeto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFimProjeto;
        private System.Windows.Forms.DateTimePicker dtpPrevisaoProjeto;
        private System.Windows.Forms.DateTimePicker dtpInicioProjeto;
        private System.Windows.Forms.Button bntSalvarProjeto;
        private System.Windows.Forms.TextBox txtProjeto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}