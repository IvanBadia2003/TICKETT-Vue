using Tickett.Models;

namespace Tickett.Business;
public interface IObraService
{
    List<Obra> GetAll();
    // GetAll(int id);
    void Add(Obra obra);
    Obra Get(int id);
    void Update(Obra obra);
    void Delete(int id);
}
