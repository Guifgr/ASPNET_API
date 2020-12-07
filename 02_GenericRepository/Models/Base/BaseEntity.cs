using System.ComponentModel.DataAnnotations.Schema;

namespace APIRest_ASPNET5.Models.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
