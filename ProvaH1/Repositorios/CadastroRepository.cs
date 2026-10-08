using ProvaH1.Models;

namespace ProvaH1.Repositorios
{
    public class CadastroRepository : ICadastrorRepository
    {
        private static List<Cadastro> Eleitor = new List<Cadastro>();

        private static int ProximoId = 1;

        public List<Cadastro> ListarCadastro()
        {
            return Eleitor;
        }

        public Cadastro? BuscarPorNome(string Nome)
        {
            return Eleitor.FirstOrDefault(
                c => c.Nome == Nome
            );
        }

        public Cadastro? BuscarPorCPF(string CPF)
        {
            return Eleitor.FirstOrDefault(
                c => c.CPF == CPF
            );
        }

        public Cadastro? BuscarPorTitulo(string Titulo)
        {
            return Eleitor.FirstOrDefault(
                c => c.Titulo == Titulo
            );
        }

        public void Adicionar(Cadastro cadastro)
        {
            cadastro.Id = ProximoId++;

            Eleitor.Add(cadastro);
        }
    }
}