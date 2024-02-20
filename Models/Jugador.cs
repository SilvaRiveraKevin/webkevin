using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webkevin.Models
{
    [Table("Jugadores")]
    public class Jugador
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string nombrejugador { get; set; }
        public string region { get; set; }
    }
}
