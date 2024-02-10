using Template.ClassLibrary.NET8.Data;
using Template.ClassLibrary.NET8.Repositories.Interfaces;

namespace Template.ClassLibrary.NET8.Repositories.Providers;

public class PgRepository : IPgRepository
{
    private readonly ApplicationDbContext _dbContext;

    public PgRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }
}