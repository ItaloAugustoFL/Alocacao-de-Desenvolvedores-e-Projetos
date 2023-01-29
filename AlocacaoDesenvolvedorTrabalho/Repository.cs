using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocacaoDesenvolvedorTrabalho
{
    internal class Repository : DbContext
    {
        private static MySqlConnection _bancodedadosconecao;
        public static Desenvolvedor DevLogado { get; set; }
        public DbSet<Desenvolvedor> Desenvolvedores { get; set; }
        public DbSet<Credencial> Credenciais { get; set; }
        public DbSet<Projeto> Projetos { get; set; }

        public static MySqlConnection GetDbConnection()
        {
            if (_bancodedadosconecao == null)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["TrabalhoProgVisual"].ConnectionString;
                _bancodedadosconecao = new MySqlConnection(connectionString);
            }
            return _bancodedadosconecao;
        }
        public Repository() : base(GetDbConnection(), false)
        {
            if (Database.CreateIfNotExists())
            {
                Repository repository = this;
                
                Desenvolvedor SrRatatoskr = new Desenvolvedor();
                SrRatatoskr.Nome = "Rato";
                SrRatatoskr.Nivel_ = 'R';
                SrRatatoskr.Nascimento = new DateTime(0001, 01, 01);

                Credencial c1 = new Credencial();
                c1.Email = "ratatoskr@gmail.com";
                c1.Senha = "esquilo123";
                c1.Ativo = true;
                c1.Adiministrador = true;
                c1.Desenvolvedor = SrRatatoskr;
                SrRatatoskr.Credencial = c1;
                repository.Desenvolvedores.Add(SrRatatoskr);
                repository.SaveChanges();
            }
        }

        
    }
}
