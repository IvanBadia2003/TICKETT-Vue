namespace Tickett.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
public class Butaca
{
    [Key]
    public int ButacaId { get; set; }
    [Required]
    public bool Libre { get; set; }

    [ForeignKey("Obra")]
    public int ObraId { get; set; }
    public Obra Obra { get; set; }
    public Butaca() { }
    public Butaca(int butacaId, bool libre, int obraId)
    {
        Libre = libre;
        ObraId = obraId;
        ButacaId = butacaId;
        //     ButacaId = butacaSeed;
        //     butacaSeed++;
        // 
    }

    public List<Butaca> GenerarButacas(int oId)
        {
            var butacas = new List<Butaca>();
            for (var i = 1; i <= 100; i++)
            {
                 butacas.Add(new Butaca(butacaId: i, obraId: oId,libre: true)); // Suponiendo que inicialmente todas las butacas están libres
            }
            return butacas;
        }


}
