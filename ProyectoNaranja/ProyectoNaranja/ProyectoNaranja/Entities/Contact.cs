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
        public string phoneNumber { get; set; }
        [StringLength(250)]
        public string cellphoneNumber { get; set; }
        [StringLength(250)]
        public int email { get; set; }
        [Required]
        [StringLength(30)]
        public string Photo { get; set; }
        [StringLength(250)]
        public int department { get; set; }
        [Required]
        [StringLength(30)]
        public string FullName { get; }
        #endregion
    }
}
