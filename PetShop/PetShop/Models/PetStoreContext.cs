using Microsoft.EntityFrameworkCore;

namespace PetShop.Models;

public class PetStoreContext : DbContext
{
    public DbSet<Animal> Animals { get; set; }
    public PetStoreContext(DbContextOptions<PetStoreContext> options) : base(options) {}
}