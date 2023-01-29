namespace AlocacaoDesenvolvedorTrabalho
{
    partial class JanelaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnunovodesenvolvedor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnunovoprojeto = new System.Windows.Forms.ToolStripMenuItem();
            this.novaTarefaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaTarefaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.registrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSobre,
            this.mnuSair});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(104, 22);
            this.mnuSobre.Text = "Sobre";
            this.mnuSobre.Click += new System.EventHandler(this.mnuSobre_Click);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(104, 22);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnunovodesenvolvedor,
            this.mnunovoprojeto,
            this.novaTarefaToolStripMenuItem,
            this.novaTarefaToolStripMenuItem1});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // mnunovodesenvolvedor
            // 
            this.mnunovodesenvolvedor.Name = "mnunovodesenvolvedor";
            this.mnunovodesenvolvedor.Size = new System.Drawing.Size(184, 22);
            this.mnunovodesenvolvedor.Text = "Novo Desenvolvedor";
            this.mnunovodesenvolvedor.Click += new System.EventHandler(this.mnunovodesenvolvedor_Click);
            // 
            // mnunovoprojeto
            // 
            this.mnunovoprojeto.Name = "mnunovoprojeto";
            this.mnunovoprojeto.Size = new System.Drawing.Size(184, 22);
            this.mnunovoprojeto.Text = "Novo Projeto";
            this.mnunovoprojeto.Click += new System.EventHandler(this.mnunovoprojeto_Click);
            // 
            // novaTarefaToolStripMenuItem
            // 
            this.novaTarefaToolStripMenuItem.Name = "novaTarefaToolStripMenuItem";
            this.novaTarefaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.novaTarefaToolStripMenuItem.Text = "Nova Alocação";
            // 
            // novaTarefaToolStripMenuItem1
            // 
            this.novaTarefaToolStripMenuItem1.Name = "novaTarefaToolStripMenuItem1";
            this.novaTarefaToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.novaTarefaToolStripMenuItem1.Text = "Nova Tarefa";
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlocacaoDesenvolvedorTrabalho.Properties.Resources.canva_photo_editor_214;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "JanelaPrincipal";
            this.Text = "JanelaPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JanelaPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnunovodesenvolvedor;
        private System.Windows.Forms.ToolStripMenuItem mnunovoprojeto;
        private System.Windows.Forms.ToolStripMenuItem novaTarefaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaTarefaToolStripMenuItem1;
    }
}