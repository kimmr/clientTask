using System;
using System.ComponentModel.DataAnnotations;

namespace CustomerList.Models
{
    public class DisplayClientModel
    {
        [Required]
        [StringLength(20, ErrorMessage ="First Name is too long")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Last Name is too long")]
        [MinLength(1, ErrorMessage = "Last name is too short")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
