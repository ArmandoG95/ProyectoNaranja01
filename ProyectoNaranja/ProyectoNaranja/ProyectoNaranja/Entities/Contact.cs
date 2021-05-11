using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNaranja.Entities
{
    public class Contact
    {
        #region propiedades autoimplementadas
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [Required]
        [StringLength(30)]
        public string PhoneNumber { get; set; }
        [StringLength(250)]
        public string CellphoneNumber { get; set; }
        
        public int Correo { get; set; }
        [Required]
        [StringLength(30)]
        public string Photo { get; set; }
        public int Department { get; set; }
        [Required]
        [StringLength(30)]
        public string FullName { get; }
        #endregion
    }
}
