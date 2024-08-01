using ASP_HomeWork_4_.Entities;
using ASP_HomeWork_4_.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_HomeWork_4_.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;

        public IQueryable<Entities.Product> Products { get; set; }
        [BindProperty]
        public Entities.Product MyProduct { get; set; } = null;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }


        public async Task OnGetAsync()
        {
            Products = await _productService.GetAllProductAsync();

            if (MyProduct == null)
            {

            MyProduct = new();
            }
           
        }

        public async Task<IActionResult> OnPostAsync()
        {
              

            if (MyProduct.Id == 0)
            {
                await _productService.AddAsync(MyProduct);

            }

            return RedirectToPage();
        }


        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            await _productService.DeleteAsync(id);
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostEditAsync(int id)
        {

            Products = await _productService.GetAllProductAsync();
            MyProduct = await _productService.GetProductByIdAsync(id);
            return Page();
        }

        public async Task<IActionResult> OnPostEditModifyAsync()
        {

            await Console.Out.WriteLineAsync("ok edit" + MyProduct.Id);
            await Console.Out.WriteLineAsync("ok edit" + MyProduct.Name);
            await Console.Out.WriteLineAsync("ok edit" + MyProduct.Description);

            await _productService.ModifyAsync(MyProduct);

            return RedirectToPage();
        }


    }
}
