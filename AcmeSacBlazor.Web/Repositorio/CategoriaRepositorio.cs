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

        public async Task<Categoria> AgregarAsync(Categoria categoria)
        {
           await _context.categorias.AddAsync(categoria);
           await _context.SaveChangesAsync();
            return categoria;
        }

        public async Task<IEnumerable<Categoria>> GetAllAsync()
        {
           return await _context.categorias.ToArrayAsync();
        }

        public async Task<Categoria> GetOneAsync(int Id)
        {
            var BuscaCategoria = await _context.categorias.FirstOrDefaultAsync(c => c.Id == Id);

            if (BuscaCategoria is null)
            {
                return new Categoria();
            }
            return BuscaCategoria;
        }

        public async Task<Categoria> ModificarAsync(Categoria categoria)
        {
            var ModificaCategoria = await _context.categorias.FirstOrDefaultAsync(m=> m.Id == categoria.Id);
            if(ModificaCategoria is not null)
            {
                ModificaCategoria.nom_categoria = categoria.nom_categoria;
                _context.categorias.Update(ModificaCategoria);
                await  _context.SaveChangesAsync ();
                return ModificaCategoria;
            }
            return categoria;
        }
    }
}
