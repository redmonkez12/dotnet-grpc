using Microsoft.EntityFrameworkCore;

namespace TodoGrpc.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    
}