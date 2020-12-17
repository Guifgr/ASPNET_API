using APIRest_ASPNET5.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIRest_ASPNET5.Models
{
    [Table("client")]
    public class Client : BaseEntity
    {        
        [Column("name")]
        public string Name { get; set; }

        [Column("cnh")]
        public string CNH { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("enabled")]
        public bool Enabled { get; set; }
    }
}