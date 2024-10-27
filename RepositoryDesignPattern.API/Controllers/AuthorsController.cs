using Microsoft.AspNetCore.Mvc;
using RepositoryDesignPattern.Core.Interfaces;
using RepositoryDesignPattern.Core.Models;

namespace RepositoryDesignPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

    }
}
