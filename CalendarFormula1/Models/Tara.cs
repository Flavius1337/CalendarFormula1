using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CalendarFormula1.Models
{
    public class Tara
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "NumeTara")]
        public string NumeTara { get; set; }

        [Display(Name = "Oras")]
        public string Oras { get; set; }

        [Display(Name = "PictureURL")]
        public string PictureURL { get; set; }

        //Relationhips
        public List<Cursa> Cursaa { get; set; }
    }
}