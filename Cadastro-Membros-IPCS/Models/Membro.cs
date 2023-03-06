using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Cadastro_Membros_IPCS.Models
{
    public class Membro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "É necessário dizer o nome do membro.")]
        public string Nome { get; set; }

        public string DataNascimento { get; set; }

        [Required(ErrorMessage = "É necessário informar se é um membro ativo.")]
        public bool MembroAtivo { get; set; }
    }
}
