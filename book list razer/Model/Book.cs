 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace book_list_razer.Model
{
    public class Book
    {
        
        [Key]// can insert data annotation and create id value automatically
        public int Id { get; set; }

        [Required]// name cannot be null 
        public String Name { get; set; }
        public String Author { get; set; }

        public String ISBN { get; set; } // model eke change ekak krana hema welawakama "add-migration abx***" denna then "update-database" commmand eka denna
    }
}
