using System.ComponentModel.DataAnnotations;
using FuncionarioWebApi.Enums;

namespace FuncionarioWebApi.Models
{
    public class FuncionarioModel
    { 
        [Key] 
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public TurnoEnum TurnoEnum { get; set; }
        public DepartamentoEnum DepartamentoEnum { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataDeCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataDeAlteracao { get; set; } = DateTime.Now.ToLocalTime();

    }
}
