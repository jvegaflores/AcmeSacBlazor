using AcmeSacBlazor.Web.Data;
using AcmeSacBlazor.Web.Repositorio.IRepositorio;
using Microsoft.EntityFrameworkCore;

namespace AcmeSacBlazor.Web.Repositorio
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly ApplicationDbContext _context;

        public Categoria Agregar(Categoria categoria)
        {
            _context.categorias.Add(categoria);
            _context.SaveChanges();
            return categoria;
        }

        public IEnumerable<Categoria> GetAll()
        {
            throw new NotImplementedException();
        }

        public Categoria GetOne(int Id)
        {
            var BuscaCategoria = _context.categorias.FirstOrDefault(c => c.Id == Id);

            if (BuscaCategoria == null)
            {
                return new Categoria();
            }
            return BuscaCategoria;
        }

        public Categoria Modificar(Categoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}
