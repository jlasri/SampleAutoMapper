using AutoMapper;
using AutoMapperDemo.Models;
using AutoMapperDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDemo.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            // Populate the user details from DB
            var user = GetUserDetails();

            UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);

            return View(userViewModel);
        }

        private static User GetUserDetails()
        {
            return new User()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                Email = "John.Smith@gmail.com",
                Address = new Address()
                {
                    Country2 = "US"
                }
            };
        }
    }
}