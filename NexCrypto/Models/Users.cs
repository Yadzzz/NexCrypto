using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexCrypto.Models
{
    public class Users
    {
        public Users(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Username { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }

        [Required]
        public bool IsAdmin { get; set; }
    }
}
