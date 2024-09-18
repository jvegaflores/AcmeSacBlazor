using AcmeSacBlazor.Web.Data;

namespace AcmeSacBlazor.Web.Repositorio.IRepositorio
{
    public interface ICategoriaRepositorio
    {
        public Categoria Agregar(Categoria categoria);
        public Categoria Modificar(Categoria categoria);
        public Categoria GetOne(int Id);
        public IEnumerable<Categoria> GetAll();
    }
}
