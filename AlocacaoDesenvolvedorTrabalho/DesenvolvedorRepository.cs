using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocacaoDesenvolvedorTrabalho
{
    internal class DesenvolvedorRepository
    {
        //clase que está no programa base passado por guisso Pegar e colocar tudo aqui
        public static void Salvar(Desenvolvedor usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (usuario.Id == 0)
                    {
                        dbContext.Desenvolvedores.Add(usuario);
                    }
                    else
                    {
                        dbContext.Entry(usuario).State
                            = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (/*DbEntityValidationException ex*/Exception)
            {
                throw;
                /*foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        Console.WriteLine("Property: " + validationError.PropertyName
                            + " Error: " + validationError.ErrorMessage);
                    }
                }*/
            }
        }

        public static List<Desenvolvedor> BuscarTudo()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Desenvolvedores.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Desenvolvedor BuscarPeloID(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Desenvolvedores.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Desenvolvedor BuscarPelaCredencial(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Desenvolvedores
                        .Include("Credencial")
                        .Where(u => u.Id == id)
                        .FirstOrDefault<Desenvolvedor>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Desenvolvedor> ProcurarPorParteDoNome(String partialName)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Desenvolvedores
                        .Where(u => u.Nome.Contains(partialName))
                        .ToList<Desenvolvedor>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Remover(Desenvolvedor usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Desenvolvedores.Attach(usuario);
                    dbContext.Desenvolvedores.Remove(usuario);

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

       /*public static void AdicionarDesenvolvedor(String nome, DateTime nascimento, Char nivel, String email, String Senha, Boolean ativo, Boolean administrador)
            {
                Desenvolvedor d = new Desenvolvedor(); 
                d.Nome = nome;
                d.Nascimento = nascimento;
                d.Nivel_ = nivel;
                Credencial c = new Credencial();
                c.Email = email;
                c.Senha = Senha;
                c.Ativo= ativo;
                c.Adiministrador = administrador;
                d.Credencial = c;
                c.Desenvolvedor = d;
                Salvar(d);
           }*/
    }
}
