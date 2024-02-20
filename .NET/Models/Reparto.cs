namespace Tickett.Models;
 using System.Text;
public class Reparto
{
    public int RepartoId { get; set; } 
    public string Nombre { get; set; } 
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
