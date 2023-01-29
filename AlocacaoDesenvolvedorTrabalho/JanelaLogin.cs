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
    public partial class JanelaLogin : Form
    {
        private static JanelaLogin _instance;
        public static JanelaLogin GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JanelaLogin();
            }
            return _instance;
        }
        public JanelaLogin()
        {
            InitializeComponent();

        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            if (CredencialRepository.ValidarDesenvolvedor(txtEmail.Text, txtSenha.Text))
            {
                this.Hide();
                JanelaPrincipal.GetInstance().Show();
            }
            else
            {
                MessageBox.Show("Ratatoskr lhe dá Tchau!");
            }
        }

        private void JanelaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
