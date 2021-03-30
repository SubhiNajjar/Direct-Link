using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectLink.Core.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "You must enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your message")]
        [MaxLength(100, ErrorMessage = "Your message must be no longer than 100 characters")]
        public string Message { get; set; }

        public int ContactFormId { get; set; }

    }
}
