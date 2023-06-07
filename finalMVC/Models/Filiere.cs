using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace finalMVC.Models
{
    public class Filiere
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(128)]
        public string Titre { get; set; }
        public string Description { get; set; }
        public Section section { get; set; }
    }
}
