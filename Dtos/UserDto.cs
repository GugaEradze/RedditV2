using Microsoft.AspNetCore.Components;
using Reddit.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Reddit.Dtos
{
    public class UserDto
    {
        [Required]
        public string Name { get; set; }
        [Required] 
        [Route("users/{emailAddress:regex(\\[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4})}")]
        
        public string Email { get; set; }

        public string GetEmail()
        {
            return Email;
        }

        public IHttpActionResult GetUser(string emailAddress, string email) => new User { Name = Name, email = Email };

        public User CreateUser() {
             return new User { Name = Name, Email = Email };
        }
    }
}
