using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocacaoDesenvolvedorTrabalho
{
    [Table("projetos")]
    internal class Projeto
    {
        public Int64 Id { get; set; }

        [StringLength(35)]
        public String Nome { get; set; }


        //datas dos projetos
        public DateTime DataInicio { get; set; }
        public DateTime DataPrevista { get; set; }
        public DateTime DataTermino { get; set; }

        public Projeto() 
        {  
        }
        public Projeto(string nome, DateTime datainicio, DateTime dataprevista, DateTime datatermino)
        {
            Nome = nome;
            DataInicio = datainicio;
            DataPrevista = dataprevista;
            DataTermino = datatermino;
        }
    }
}
