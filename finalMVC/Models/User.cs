using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace finalMVC.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(128)]
        public string NomComplet { get; set; }
        [StringLength(128)]
        public string Email { get; set; }
        [StringLength(128)]
        public string Telephone { get; set; }
        public string Password { get; set; }
    }
}
