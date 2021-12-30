
using Microsoft.EntityFrameworkCore;

namespace OData.Models
{
    public class ODataContext : DbContext
    {
        public ODataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
    }
}