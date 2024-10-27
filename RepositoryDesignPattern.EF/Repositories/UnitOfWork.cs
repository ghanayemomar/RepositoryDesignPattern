using RepositoryDesignPattern.Core.Interfaces;
using RepositoryDesignPattern.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.EF.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IBaseRepository<Author> Authors { get; set; }
        public IBaseRepository<Book> Books { get; set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Authors = new BaseRepository<Author>(_context);
            Books = new BaseRepository<Book>(_context);
        }
        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

    }
}