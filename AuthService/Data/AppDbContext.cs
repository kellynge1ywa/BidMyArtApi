using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthService;

public class AppDbContext:IdentityDbContext<AuctionUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
        
    }

    public DbSet<AuctionUser> AuctionUsers {get;set;}

}
