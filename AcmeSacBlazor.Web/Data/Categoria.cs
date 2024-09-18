using System.ComponentModel.DataAnnotations;

namespace AcmeSacBlazor.Web.Data
{
    public class Categoria
    {
        public int Id { get; set; }
       
        [Required(ErrorMessage ="Por favor ingrese el nombre de Categoria")]
        public string nom_categoria { get; set; }
    }
}
