using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace BulkyBook.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        //  navigation property or relationship making property 
        public int? CompanyId { get; set; }
        public Company Company { get; set; }



        [NotMapped]
        public string Role { get; set; }


      

    }
}
