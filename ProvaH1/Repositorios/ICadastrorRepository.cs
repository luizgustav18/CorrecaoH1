using ProvaH1.Models;

namespace ProvaH1.Repositorios
{
    public interface ICadastrorRepository
    {
        List<Cadastro> ListarCadastro();

        Cadastro? BuscarPorNome(string Nome);
        Cadastro? BuscarPorCPF(string CPF);
        Cadastro? BuscarPorTitulo(string Titulo);
        void Adicionar(Cadastro cadastro);
    }
}