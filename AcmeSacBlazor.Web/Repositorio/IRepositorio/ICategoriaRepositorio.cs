using AcmeSacBlazor.Web.Data;

namespace AcmeSacBlazor.Web.Repositorio.IRepositorio
{
    public interface ICategoriaRepositorio
    {
        public Task<Categoria> Agregar(Categoria categoria);
        public Task<Categoria> Modificar(Categoria categoria);
        public Task<Categoria> GetOneAsync(int Id);
        public Task<IEnumerable<Categoria>> GetAllAsync();
    }
}
