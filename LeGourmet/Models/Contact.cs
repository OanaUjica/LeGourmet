using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeGourmet.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }
    }
}
