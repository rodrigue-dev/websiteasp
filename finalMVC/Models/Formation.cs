using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finalMVC.Models
{
    public class Formation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(128)]
        public required string Titre { get; set; }
        public string Description { get; set; }
        [StringLength(128)]
        public string Lieu { get; set; }
        [StringLength(128)]
        public DateTime Dateformation { get; set; }
        public string ThumbnailPath { get; set; }
        public Section section { get; set; }
    }
}
