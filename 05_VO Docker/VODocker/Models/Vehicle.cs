using APIRest_ASPNET5.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIRest_ASPNET5.Models
{
    [Table("vehicle")]
    public class Vehicle : BaseEntity
    {
        [Column("model")]
        public string Model { get; set; }

        [Column("theyear")]
        public long Year { get; set; }

        [Column("plate")]
        public string Plate { get; set; }

        [Column("color")]
        public string Color { get; set; }

        [Column("enabled")]
        public bool Enabled { get; set; }
    }
}
