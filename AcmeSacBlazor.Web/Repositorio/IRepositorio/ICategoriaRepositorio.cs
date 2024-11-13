using AcmeSacBlazor.Web.Data;

namespace AcmeSacBlazor.Web.Repositorio.IRepositorio
{
    public interface ICategoriaRepositorio
    {
        public Task<Categoria> AgregarAsync(Categoria categoria);
        public Task<Categoria> ModificarAsync(Categoria categoria);
        public Task<Categoria> GetOneAsync(int Id);
        public Task<IEnumerable<Categoria>> GetAllAsync();
    }
}
