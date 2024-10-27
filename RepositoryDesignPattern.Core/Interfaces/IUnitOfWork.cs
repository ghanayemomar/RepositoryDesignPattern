using RepositoryDesignPattern.Core.Models;

namespace RepositoryDesignPattern.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Author> Authors { get; }
        IBaseRepository<Book> Books { get; }
        Task<int> Complete();

    }
}
