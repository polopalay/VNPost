using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VNPost.Models.ViewModels
{
    public class HeaderViewModel : PageModel
    {
        public string Name { get; set; }
        public void OnGet()
        {
            Name = "Test product";
        }
    }
}
