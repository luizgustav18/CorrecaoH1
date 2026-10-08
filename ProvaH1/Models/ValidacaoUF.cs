using System.ComponentModel.DataAnnotations;

namespace ProvaH1.Models
{
    public class ValidacaoUF : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("O campo UF é obrigatório.");
            }

            string uf = value.ToString().ToUpper();
            if ( uf == "MG"|| uf == "SP" || uf == "RJ" || uf == "ES")
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("UF inválida. As opções válidas são: MG, SP, RJ, ES.");
        }
    }
}
