using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Services;
using WebApplication2.Services.Interface;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICustomerServices _customerServices;
        private readonly IUserServices _userServices;
        public string UserId { get; set; }
        public string CustomerId { get; set; }
        public IndexModel(IUserServices userServices,
            ICustomerServices customerServices)
        {
            _customerServices = customerServices;
            _userServices = userServices;
        }

        public void OnGet()
        {
            CustomerId = _customerServices.GetCustomerId();
            //UserId = _userServices.GetUserId();

        }
    }
}