using System.ComponentModel.DataAnnotations;

namespace ProvaH1.Models
{
    public class Justificativa
    {
        [Required(ErrorMessage = "A descrição é obrigatoria.")]
        [StringLength(500, MinimumLength = 6, ErrorMessage = "A descração deve ter no minímo de 6 caracteres ")]
        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "O CPF é obrigatório. ")]
        public string CPF { get; set; } = string.Empty;

        [Required(ErrorMessage = "O número do turno é obrigatório.")]
        [Range(1,2,ErrorMessage = "O número do turno deve ser 1 ou 2.")]
        public int NumeroDeTurno { get; set; }
    }
}
