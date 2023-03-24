using System.ComponentModel.DataAnnotations;

namespace Panchito.Store02.Entity
{
    internal class Product
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string code { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }
        [Required]
        [StringLength(500)]
        public string descripcion { get; set; }

        [Required]
        public int Stock { get; set; }
    }
}
