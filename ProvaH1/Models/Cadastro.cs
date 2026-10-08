using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ProvaH1.Models
{
    public class Cadastro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do usuario é obrigatório. ")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 a 50 caracteres. ")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O CPF é obrigatório. ")]
        [RegularExpression(@"^\d{11}$",
            ErrorMessage = "O CPF deve possuir exatamente 11 dígitos.")]
        public string CPF { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Título deve ser obrigatório.")]
        [StringLength(50, ErrorMessage = "O Título deve estar completo.")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "A UF deve ser obrigatória.")]
        [ValidacaoUF]
        public string UF { get; set; } = string.Empty;


    }
}
