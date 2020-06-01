using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using book_list_razer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace book_list_razer.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty] // book object eka kelinma gnnawa kranne
        public Book Book { get; set; }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Book.AddAsync(Book); // add a book to db 
                await _db.SaveChangesAsync(); //then  changes are pushed to db
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}