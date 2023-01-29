using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlocacaoDesenvolvedorTrabalho
{
    internal class CredencialRepository
    {
        //dando erro no email.
        public static Desenvolvedor BuscarPorEmail(String email)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Desenvolvedores.Include
                        ("Credencial").Where(d => d.Credencial.Email == email).
                        FirstOrDefault();
                    //<Desenvolvedor>
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Boolean ValidarDesenvolvedor(String email, String senha)
        {
            Desenvolvedor dev = BuscarPorEmail(email);

            if (dev != null)
            {
                if (dev.Credencial.Ativo)
                {
                    if (dev.Credencial.Senha == Credencial.ComputeSHA256(senha, Credencial.Salt))
                    {
                        JanelaPrincipal.DesenvolvedorLogado = dev;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("O ratatoskr não encontrou esta senha em toda midgard! Tente Denovo!");
                        return false;

                    }
                }
                else
                {
                    MessageBox.Show("Este filho de ratatoskr não está ativo!");
                    return false;
                }
                
            }
            else
            {
                return false;
            }
        }
    }
}
