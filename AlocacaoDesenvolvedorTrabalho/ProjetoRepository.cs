using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlocacaoDesenvolvedorTrabalho
{
    internal class ProjetoRepository
    {
        //Fazer a mesma coisa que ja tem no programa que guisso passou, so que agora para os  novos projetos a serem feitos
        public static void Salvar(Projeto proj)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (proj.Id == 0)
                    {
                        dbContext.Projetos.Add(proj);
                    }
                    else
                    {
                        dbContext.Entry(proj).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Projeto> Buscar()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Projetos.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Projeto BuscarPorId(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Projetos.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Projeto> BuscarPorParteDoNome(String partialName)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Projetos
                        .Where(p => p.Nome.Contains(partialName))
                        .ToList<Projeto>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Remover(Projeto proj)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Projetos.Attach(proj);
                    dbContext.Projetos.Remove(proj);

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
