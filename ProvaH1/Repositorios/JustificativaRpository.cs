using ProvaH1.Models;

namespace ProvaH1.Repositorios
{
    public class JustificativaRpository : IJustificativaRpository
    {
        private static List<Justificativa> Justificativas =
            new List<Justificativa>();

        public List<Justificativa> ListarJustificativas()
        {
            return Justificativas;
        }

        public Justificativa? BuscarPorCPF(string CPF)
        {
            return Justificativas.FirstOrDefault(
                j => j.CPF == CPF
            );
        }

        public Justificativa? BuscarPorCPFETurno(
            string CPF,
            int NumTurno)
        {
            return Justificativas.FirstOrDefault(
                j => j.CPF == CPF &&
                     j.NumeroDeTurno == NumTurno
            );
        }

        public void Adicionar(Justificativa justificativa)
        {
            Justificativas.Add(justificativa);
        }
    }
}