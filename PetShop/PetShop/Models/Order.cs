namespace PetShop.Models;

public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string ContactPhone { get; set; }
    
    public int AnimalId { get; set; }
    public Animal? Animal { get; set; }
}