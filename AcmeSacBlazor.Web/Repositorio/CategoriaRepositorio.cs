using AcmeSacBlazor.Web.Data;
using AcmeSacBlazor.Web.Repositorio.IRepositorio;
using Microsoft.EntityFrameworkCore;

namespace AcmeSacBlazor.Web.Repositorio
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly ApplicationDbContext _context;

        public CategoriaRepositorio(ApplicationDbContext applicationDb)
        {
            _context = applicationDb;
        }

        public Categoria Agregar(Categoria categoria)
        {
            _context.categorias.Add(categoria);
            _context.SaveChanges();
            return categoria;
        }

        public IEnumerable<Categoria> GetAll()
        {
           return _context.categorias.ToList();
        }

        public Categoria GetOne(int Id)
        {
            var BuscaCategoria = _context.categorias.FirstOrDefault(c => c.Id == Id);

            if (BuscaCategoria is not null)
            {
                return new Categoria();
            }
            return BuscaCategoria;
        }

        public Categoria Modificar(Categoria categoria)
        {
            var ModificaCategoria = _context.categorias.FirstOrDefault(m=> m.Id == categoria.Id);
            if(ModificaCategoria is not null)
            {
                ModificaCategoria.nom_categoria = categoria.nom_categoria;
                _context.categorias.Update(ModificaCategoria);
                _context.SaveChanges();
                return ModificaCategoria;
            }
            return categoria;
        }
    }
}
