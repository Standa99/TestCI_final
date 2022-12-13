using Microsoft.EntityFrameworkCore;

namespace TestCI_app_SLN.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
    }
}
