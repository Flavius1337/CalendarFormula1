using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CalendarFormula1.Models
{
    public class Piloti
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage = "Poza de profi este necesara")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "NumePilot")]
        [Required(ErrorMessage = "Numele pilotului este necesara")]
        public string NumePilot { get; set; }

        [Display(Name = "NumarPilot")]
        [Required(ErrorMessage = "Numarul pilotului este necesar")]
        public int NumarPilot { get; set; }

        [Display(Name = "Echipa")]
        [Required(ErrorMessage = "Numele echipei este necesar")]
        public string Echipa { get; set; }

        //Relationships
        public List<Piloti_Cursa> Pilotii_Cursaa { get; set; }
    }
}