using System.ComponentModel.DataAnnotations;

namespace Tickett.Models;
using System.Text;
public class Obra
{
    [Key]
    public int ObraId { get; set; }
    [Required]
    public string Titulo { get; set; }
    [Required]
    public string Descripcion { get; set; }
    [Required]
    public DateTime DiaObra { get; set; }
    [Required]
    public TimeSpan HoraObra { get; set; }
    [Required]
    public string Imagen { get; set; }
    public List<ObraReparto> ListaObraReparto { get; set; }
    [Required]
    public string Genero { get; set; }
    [Required]
    public int Duracion { get; set; }
    [Required]
    public int Precio { get; set; }
    [Required]
    public List<Butaca> ListaButaca { get; set; }

    public static int obraSeed = 1;

    public Obra() { }

    public Obra(string titulo, string descripcion, DateTime diaObra, TimeSpan horaObra, string imagen, string genero, int duracion, int precio)
    {
        Titulo = titulo;
        Descripcion = descripcion;
        DiaObra = diaObra;
        HoraObra = horaObra;
        Imagen = imagen;
        Genero = genero;
        Duracion = duracion;
        Precio = precio;
        ObraId = obraSeed;
        obraSeed++;


    }
}
