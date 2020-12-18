using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIRest_ASPNET5.Models
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("fullname")]
        public string Name { get; set; }

        [Column("refresh_token")]
        public string RefreshToken { get; set; }
        
        [Column("refresh_token_expiry_time")]
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}