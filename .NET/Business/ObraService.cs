using Tickett.Data;
using Tickett.Business;
using Tickett.Models;


namespace Tickett.Business
{
    public class ObraService : IObraService
    {

        private readonly IObraRepository _obraRepository;
        

        public ObraService(IObraRepository obraRepository){
            _obraRepository = obraRepository;
        
        }
        public  List<Obra> GetAll()
        {
            var pizzas = _obraRepository.GetAll();
            // foreach (var pizza in pizzas)
            // {
            //     pizza.Ingredientes = _ingredientesRepository.GetIngredientesByPizzaId(pizza.Id);
            // }
            return pizzas;
        }

        public  Obra Get(int id)
        {
            var pizza = _obraRepository.Get(id);

            // if (pizza != null)
            // {
            //     pizza.Ingredientes = _ingredientesRepository.GetIngredientesByPizzaId(pizza.Id);
            // }

            return pizza;
        }
          

    public  void Add(Obra obra)
    {
        _obraRepository.Add(obra);

            // foreach (var ingrediente in pizza.Ingredientes)
            // {
            //     _ingredientesRepository.AddIngredienteToPizza(ingrediente, pizza.Id);
            // }
    }

    public  void Update(Obra obra)
    {
        _obraRepository.Update(obra);

            // _ingredientesRepository.UpdateIngredientesForPizza(pizza.Ingredientes, pizza.Id);
    }

    public  void Delete(int id)
    {
        _obraRepository.Delete(id);
    }
}


        
    }

