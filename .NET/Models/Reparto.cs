namespace Tickett.Models;

using System.ComponentModel.DataAnnotations;
using System.Text;
public class Reparto
{
    [Key]
    public int RepartoId { get; set; } 
    [Required]
    public string Nombre { get; set; } 
    [Required]
    public string Rol { get; set; }
    public List <ObraReparto> ListaObraReparto { get; set; }
    public static int repartoSeed = 1;

    public Reparto(){}

    public Reparto(string nombre, string rol){  
        Nombre = nombre;
        Rol = rol;
        RepartoId = repartoSeed;
        repartoSeed++;
    }
}
