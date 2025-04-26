using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspNetCore1.Pages
{
    public class IndexNewModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexNewModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
