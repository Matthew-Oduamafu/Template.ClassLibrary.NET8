namespace Template.ClassLibrary.NET8.Repositories.Interfaces;

public interface IPgRepository
{
    Task<int> SaveChangesAsync();
}