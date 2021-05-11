using System.ComponentModel.DataAnnotations;

namespace ProyectoNaranja.Entities
{
    public class Coach
    {
        #region
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [StringLength(30)]
        public string LastName { get; set; }
        [StringLength(30)]
        public string PhoneNumber { get; set; }
        [StringLength(30)]
        public string CellPhoneNumber { get; set; }
        [StringLength(30)]
        public string Correo { get; set; }
        [StringLength(30)]
        public string Photo { get; set; }
        public string FullName { get { return $"{FirstName} { LastName}"; } }
        #endregion
    }
}
