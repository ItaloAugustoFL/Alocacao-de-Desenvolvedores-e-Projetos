using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace AlocacaoDesenvolvedorTrabalho
{
    [Table("alocacao")]
    internal class Alocacao
    {
        public Int64 Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public Byte HorasSemanais { get; set; }
        public Decimal Remuneracao { get; set; }
        public Projeto Projeto { get; set; }
        public Desenvolvedor Desenvolvedor { get; set; }
        public List<Tarefa> Tarefas { get; set; }

        public Alocacao()
        {
            Tarefas = new List<Tarefa>();
        }

        public Alocacao(long id, DateTime dataInicio, DateTime dataTermino, byte horasSemanais, decimal remuneracao, Projeto projeto, Desenvolvedor desenvolvedor)
        {
            Id = id;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
            HorasSemanais = horasSemanais;
            Remuneracao = remuneracao;
            Projeto = projeto;
            Desenvolvedor = desenvolvedor;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
