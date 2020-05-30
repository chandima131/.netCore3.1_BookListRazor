using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using book_list_razer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace book_list_razer.Pages.BookList
{
    public class indexModel : PageModel
    {

        //dependency injection
        private readonly ApplicationDbContext _db;
        
        //constructor
        public indexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        //return the list
        public IEnumerable<Book > Books { get; set; }
        public async Task OnGet()
        {
            Books = await _db.Book.ToListAsync();
        }
    }
}