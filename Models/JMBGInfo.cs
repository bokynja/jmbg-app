using System;
using System.ComponentModel.DataAnnotations;

namespace JMBGApi.Models
{
    public class JMBGInfo
    {
        [Required(ErrorMessage = "Ime je obavezno.")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Prezime je obavezno.")]
        public string Prezime { get; set; }

        [Required(ErrorMessage = "JMBG je obavezan.")]
        [StringLength(13, ErrorMessage = "JMBG mora imati tačno 13 cifara.")]
        [RegularExpression("^[0-9]{13}$", ErrorMessage = "JMBG mora sadržati samo brojeve.")]
        public string JMBG { get; set; }
    }
}
