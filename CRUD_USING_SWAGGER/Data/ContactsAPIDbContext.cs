using Microsoft.EntityFrameworkCore;
namespace CRUD_USING_SWAGGER.Data
{
    public class ContactsAPIDbContext : DbContext

    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Models.Contact> Contacts{ get; set; }
    }
}
