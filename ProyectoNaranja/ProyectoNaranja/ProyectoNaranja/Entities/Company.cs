using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNaranja.Entities
{
    public class Company
    {
        #region Propiedades Autoimplementadas
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Address { get; set; }
        [Required]
        [StringLength(30)]
        public string PostalCode { get; set; }
        [Required]
        [StringLength(30)]
        public string PhoneNumber { get; set; }
        public string Photo { get; set; }
        [StringLength(50)] 
        public string Email { get; set; }
        [StringLength(50)] 
        public string Website { get; set; }
        #endregion
    }
}
