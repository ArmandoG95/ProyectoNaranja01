﻿using System.ComponentModel.DataAnnotations;
namespace ProyectoNaranja.Entities
{
    class Adviser
    {
        #region
        [key]
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
        public string Email { get; set; }
        [StringLength(30)]
        public string Deparment { get; set; }
        [StringLength(30)]
        public string Photo { get; set; }
        public string FullName { get { return $"{FirstName} { LastName}"; } }
        #endregion
    }
}
