using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace finalMVC.Models
{
    public class Preinscription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(128)]
        public DateTime datepreinscription { get; set; }
        public Apprenant apprenant { get; set; }
        public Formation formation { get; set; }
    }
}
