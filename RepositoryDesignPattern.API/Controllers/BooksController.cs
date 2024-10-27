using Microsoft.AspNetCore.Mvc;
using RepositoryDesignPattern.Core.Interfaces;

namespace RepositoryDesignPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BooksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
