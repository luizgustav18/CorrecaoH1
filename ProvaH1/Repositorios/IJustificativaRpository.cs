using ProvaH1.Models;

namespace ProvaH1.Repositorios
{
    public interface IJustificativaRpository
    {
        List<Justificativa> ListarJustificativas();

        Justificativa? BuscarPorCPF(string CPF);
        Justificativa? BuscarPorCPFETurno(string CPF, int NumTurno);

        void Adicionar(Justificativa justificativa);
    }
}
