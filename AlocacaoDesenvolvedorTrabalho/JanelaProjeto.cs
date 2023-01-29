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
    public partial class JanelaProjeto : Form
    {
        private static JanelaProjeto _instance;
        public static JanelaProjeto GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JanelaProjeto ();
            }
            _instance.MdiParent = JanelaPrincipal.ActiveForm;
            return _instance;
        }
        public JanelaProjeto()
        {
            InitializeComponent();
        }

        private void bntSalvarProjeto_Click(object sender, EventArgs e)
        {
            //salvando projeto dando erro
            Projeto projetin = new Projeto(txtProjeto.Text, dtpInicioProjeto.Value, dtpPrevisaoProjeto.Value, dtpFimProjeto.Value);
            ProjetoRepository.Salvar(projetin);
        }
    }
}
