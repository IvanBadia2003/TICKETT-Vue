namespace Tickett.Models;

using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;
public class Sesion
{
    [Key]
    public int SesionId { get; set; }
    public int ObraId { get; set; }
    public Obra Obra { get; set; }
    [Required]
    public DateTime DiaObra { get; set; }
    [Required]
    public TimeSpan HoraObra { get; set; }
    // public List<Butaca> ListaButacas { get; set; }

    public static int sesionSeed = 1;

    public Sesion() { }

    public Sesion(int obraId, DateTime diaObra)
    {
        ObraId = obraId;
        DiaObra = diaObra;
        SesionId = sesionSeed;
        sesionSeed++;
    }

    
}
