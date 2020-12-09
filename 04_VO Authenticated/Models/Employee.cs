using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIRest_ASPNET5.Models
{
    [Table("employee")]
    public class Employee
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("user_name")]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("refresh_token")]
        public long RefreshToken { get; set; }
        
        [Column("refresh_token_expiry_time")]
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}