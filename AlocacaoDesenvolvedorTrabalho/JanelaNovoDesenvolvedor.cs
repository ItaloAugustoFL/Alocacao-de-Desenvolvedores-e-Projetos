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
    public partial class JanelaNovoDesenvolvedor : Form
    {
        private static JanelaNovoDesenvolvedor _instance;
        public static JanelaNovoDesenvolvedor GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JanelaNovoDesenvolvedor();
            }
            _instance.MdiParent = JanelaPrincipal.ActiveForm;
            return _instance;
        }
        public JanelaNovoDesenvolvedor()
        {
            InitializeComponent();

            List<char> charList = new List<char> { Convert.ToChar("S"), Convert.ToChar("J"), Convert.ToChar("I")};
            cbxNivelDesenvolvedor.DataSource = charList;
            cbxNivelDesenvolvedor.SelectedIndex = 2;

        }

        private void btnSalvarDesenvolvedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (CredencialRepository.BuscarPorEmail(txtEmailDesenvolvedor.Text) != null)
                {
                    MessageBox.Show("Este email ja existe em um dos galhos da Yggdrasil");
                }
                else
                {
                    
                    //if (txtSenhaDesenvolvedor.Text.Length >= 8 && txtSenhaDesenvolvedor.Text.Length <= 12)
                    try
                    {
                        Credencial c1 = new Credencial(txtEmailDesenvolvedor.Text, txtSenhaDesenvolvedor.Text, chbAtivo.Checked, chbAdiministrador.Checked);
                        Desenvolvedor d2 = new Desenvolvedor(txtNomeDesenvolvedor.Text, dtpNascimento.Value.Date, Convert.ToChar(cbxNivelDesenvolvedor.Text), c1);
                        d2.Credencial = c1;
                        DesenvolvedorRepository.Salvar(d2);
                       // DesenvolvedorRepository.AdicionarDesenvolvedor(txtNomeDesenvolvedor.Text, dtpNascimento.Value.Date, Convert.ToChar(cbxNivelDesenvolvedor.Text), txtEmailDesenvolvedor.Text, txtSenhaDesenvolvedor.Text, chbAtivo.Checked, chbAdiministrador.Checked);
                        MessageBox.Show("Mais um filho de Ratatoskr Adicionado!");
                        txtNomeDesenvolvedor.Clear();
                        txtEmailDesenvolvedor.Clear();
                        dtpNascimento.ResetText();
                        cbxNivelDesenvolvedor.SelectedIndex = 2;
                        txtSenhaDesenvolvedor.Clear();
                        chbAtivo.Checked = false;
                        chbAdiministrador.Checked = false;
                        txtNomeDesenvolvedor.Focus();
                    }

                    //else
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        //Ratatoskr cansou de procurar essa senha em toda a existência. "
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Não deixe de preencher todos os parâmetros, Ratatoskr não gosta");
                throw;
            }
        }
    } }
