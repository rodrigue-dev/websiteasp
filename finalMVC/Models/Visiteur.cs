using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace finalMVC.Models
{
    public class Visiteur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(128)]
        public string IPaddress { get; set; }
        public DateTime Datevisite { get; set; }
    }
}
