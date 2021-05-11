using System.ComponentModel.DataAnnotations;

namespace ProyectoNaranja.Entities
{
    public class Major
    {
        #region Propiedades Autoimplementadas
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        [StringLength(25)]
        public string Photo { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        #endregion
    }
}
