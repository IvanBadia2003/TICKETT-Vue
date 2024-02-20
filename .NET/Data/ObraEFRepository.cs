using Tickett.Models;
using System.Text.Json;
using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Tickett.Data;

namespace Tickett.Data
{

    public class ObraEFRepository : IObraRepository
    {


        private readonly ObraContext _context;

        public ObraEFRepository(ObraContext context)
        {

            _context = context;
        }

        public List<Obra> GetAll()
        {
            return _context.Obras.ToList();
            // var pizzas = _context.Pizzas
            //     .Include(p => p.PizzaIngredientes)
            //         .ThenInclude(pi => pi.Ingrediente)
            //     .ToList();

            // var pizzasDto = pizzas.Select(p => new PizzaDto
            // {
            //     Id = p.Id,
            //     Name = p.Name,
            //     PizzaIngredientes = p.PizzaIngredientes.Select(pi => new IngredienteDto
            //     {
            //         Id = pi.Ingrediente.Id,
            //         Name = pi.Ingrediente.Name
            //     }).ToList()
            // }).ToList();

            // return pizzasDto;
        }

        public void Add(Obra obra)
        {
            _context.Obras.Add(obra);
            SaveChanges();
        }

        public Obra Get(int id)
        {
            return _context.Obras.FirstOrDefault(obra => obra.ObraId == id);
        }

        public void Update(Obra obra)
        {
            _context.Entry(obra).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int id)
        {
            var obra = Get(id);
            if (obra is null)
            {
                throw new KeyNotFoundException("Pizza not found.");
            }
            _context.Obras.Remove(obra);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }

}