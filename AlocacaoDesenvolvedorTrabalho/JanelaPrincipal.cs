using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlocacaoDesenvolvedorTrabalho
{
    public partial class JanelaPrincipal : Form
    {
        private static JanelaPrincipal _instance;
        public static Desenvolvedor DesenvolvedorLogado { get; set; }
        public static JanelaPrincipal GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JanelaPrincipal();
            }
            return _instance;
        }
        public JanelaPrincipal()
        {
            InitializeComponent();

            if (DesenvolvedorLogado.Credencial.Adiministrador)
            {
                
                mnunovoprojeto.Enabled = true;
            }
            else
            {
                
                mnunovoprojeto.Enabled = false;
            }
        }

        private void mnunovodesenvolvedor_Click(object sender, EventArgs e)
        {
            JanelaNovoDesenvolvedor.GetInstance().Show();
        }

        private void mnunovoprojeto_Click(object sender, EventArgs e)
        {
            JanelaProjeto.GetInstance().Show();
        }

        private void mnuSobre_Click(object sender, EventArgs e)
        {
            SobreMim.GetInstance().Show();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
            JanelaLogin.GetInstance().Show();
        }

        private void JanelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

            JanelaLogin.GetInstance().Show();
        }
    }
}
