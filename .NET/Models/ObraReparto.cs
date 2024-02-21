namespace Tickett.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
public class ObraReparto
{
    [ForeignKey("Obra")]
    public int ObraId { get; set; }
    [Required]
    public Obra Obra { get; set; }

    [ForeignKey("Reparto")]
    public int RepartoId {get; set;}
    [Required]
    public Reparto Reparto{get; set;}

    public ObraReparto(){}

    public ObraReparto(Obra obra, Reparto reparto){
        Obra = obra;
        Reparto = reparto;
    }

}
