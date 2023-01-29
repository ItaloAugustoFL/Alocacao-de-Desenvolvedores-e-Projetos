using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlocacaoDesenvolvedorTrabalho
{
    [Table("desenvolvedores")]
    public class Desenvolvedor
    {
        //não necessita falar que é primary key, pois vai automatico ao ID
        public Int64 Id { get; set; }

        [Required]
        [StringLength(45)]
        public String Nome { get; set; }
        public Credencial Credencial { get; set; }
        public DateTime Nascimento { get; set; }
        public Char Nivel_ { get; set; }

        public String Nivel
        {
            get
            {
                return Nivel_.ToString();
            }
            set
            {
                Nivel_ = value[0];
            }
        }
        public Desenvolvedor()
        {
        }
        public Desenvolvedor(string nome)
        {
            Nome = nome;
        }
        public Desenvolvedor(string nome, DateTime nasc, char level, Credencial credencial)
        {
            Nome = nome;
            Nascimento = nasc;
            Nivel_ = level;
            Credencial = credencial;
        }
    }
}
