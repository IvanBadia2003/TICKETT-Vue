namespace Tickett.Models;

using System.ComponentModel.DataAnnotations;
using System.Text;
public class Butaca
{
    [Key]
    public int ButacaId { get; set; }
    [Required]
    public bool Libre { get; set; }
    public int ObraId { get; set; }
    public Obra Obra { get; set; }
    public static int butacaSeed = 1;
    public Butaca() { }

    public Butaca(bool libre)
    {
        Libre = libre;
        ButacaId = butacaSeed;
        butacaSeed++;
    }

}
