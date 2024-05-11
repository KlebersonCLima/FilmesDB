namespace FilmesDB.Infra.Repositorios
{
    public interface IRepositorio<T>
    {
        public T BuscarPorId(int id);
        public IEnumerable<T> BuscarTodos();
        public T BuscarPorNome(string nome);
        public void Inserir(T dado);
        public void Atualizar(T dado);
        public void Deletar(T dado);
    }
}
