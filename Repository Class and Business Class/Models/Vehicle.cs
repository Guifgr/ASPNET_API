using System.ComponentModel.DataAnnotations.Schema;

namespace APIRest_ASPNET5.Models
{
    [Table("vehicle")]
    public class Vehicle
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("model")]
        public string Model { get; set; }

        [Column("theyear")]
        public string Year { get; set; }

        [Column("plate")]
        public long Plate { get; set; }

        [Column("color")]
        public string Color { get; set; }
    }
}
