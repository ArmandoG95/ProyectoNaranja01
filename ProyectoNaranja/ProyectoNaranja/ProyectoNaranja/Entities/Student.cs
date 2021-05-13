using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNaranja.Entities
{
    public class Student
    {
        #region Propiedades Auto Implementadas 
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
        [StringLength(250)]
        public string Photo { get; set; }
        [StringLength(30)]
        public string Birthdate { get; set; }
        public string FullName { get { return $"{FirstName} { LastName}"; } }
        #endregion
    }
}
