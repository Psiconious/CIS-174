using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MultipageWebAppDB.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a number.")]
        [Range(1000000000, 9999999999, ErrorMessage = "Year Must be after 1889.")]
        public long? Number { get; set; }
        [Required(ErrorMessage = "Please enter an address.")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Please enter a note.")]
        public string? Note { get; set; }

        public string Slug => Name?.Replace(' ', '-').ToLower();
    }
}
