using System.ComponentModel.DataAnnotations;

namespace AutoMapperDemo.ViewModels
{
    public class UserViewModel
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Country")]
        public string AddressCountry2 { get; set; }

        public string Email { get; set; }
    }
}
