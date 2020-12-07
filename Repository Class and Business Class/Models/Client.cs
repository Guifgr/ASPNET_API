using System.ComponentModel.DataAnnotations.Schema;

namespace APIRest_ASPNET5.Models
{
    [Table("client")]
    public class Client
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("cnh")]
        public string CNH { get; set; }

        [Column("age")]
        public long Age { get; set; }

        [Column("gender")]
        public string Gender { get; set; }
    }
}
