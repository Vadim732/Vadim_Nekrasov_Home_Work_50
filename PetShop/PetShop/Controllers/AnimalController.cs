using Microsoft.AspNetCore.Mvc;
using PetShop.Models;

namespace PetShop.Controllers;

public class AnimalController : Controller
{
    private readonly PetStoreContext _context;

    public AnimalController(PetStoreContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
        List<Animal> animals = _context.Animals.ToList();
        return View(animals);
    }
    
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Animal? animal)
    {
        if (animal != null)
        {
            _context.Add(animal);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(animal);
    }
}