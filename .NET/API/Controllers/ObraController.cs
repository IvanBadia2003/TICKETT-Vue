using Tickett.Models;
using Tickett.Business;
using Microsoft.AspNetCore.Mvc;


namespace Tickett.Controllers;

[ApiController]
[Route("[controller]")]
public class ObraController : ControllerBase
{
    private readonly IObraService _obraService;
    public ObraController(IObraService obraService)
    {
        _obraService = obraService;
    }

    [HttpGet]
    public ActionResult<List<Obra>> GetAll() =>
    _obraService.GetAll();



    [HttpGet]
    [Route("{id}")]
    public ActionResult<Obra> Get(int id)
    {
        var obra = _obraService.Get(id);

        if (obra == null){
            return NotFound();
        }else{
            return obra;
        }
    }




    [HttpPost]
    public IActionResult Create(Obra obra)
    {
        _obraService.Add(obra);
        return CreatedAtAction(nameof(Get), new { id = obra.ObraId }, obra);
    }




    [HttpPut("{id}")]
    public IActionResult Update(int id, Obra obra)
    {
        if (id != obra.ObraId)
            return BadRequest();

        var existingObra = _obraService.Get(id);
        if (existingObra is null)
            return NotFound();

        _obraService.Update(obra);

        return NoContent();
    }




    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var obra = _obraService.Get(id);

        if (obra is null)
            return NotFound();

        _obraService.Delete(id);

        return NoContent();
    }
}