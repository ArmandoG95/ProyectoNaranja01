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
        
        [StringLength(30)]
        public string LastName { get; set; }
        
        [StringLength(30)]
        public string PhoneNumber { get; set; }
        [StringLength(250)]
        public string CellphoneNumber { get; set; }
        
        public int Correo { get; set; }
        
        [StringLength(30)]
        public string Photo { get; set; }
        public int Department { get; set; }
        
        [StringLength(30)]
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        #endregion
    }
}
