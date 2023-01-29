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
    public partial class SobreMim : Form
    {
        private static SobreMim _instance;
        public static SobreMim GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new SobreMim();
            }
            _instance.MdiParent = JanelaPrincipal.ActiveForm;
            return _instance;
        }
        public SobreMim()
        {
            InitializeComponent();
        }
    }
}
