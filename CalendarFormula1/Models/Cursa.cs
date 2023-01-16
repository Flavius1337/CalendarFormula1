using CalendarFormula1.Data.Enums;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalendarFormula1.Models
{
    public class Cursa
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "NumeCursa")]
        public string NumeCursa { get; set; }

        [Display(Name = "Descriere")]
        public string Descriere { get; set; }

        [Display(Name = "ImageURL")]
        public string ImageURL { get; set; }

        [Display(Name = "DataCursa")]
        public double DataCursa { get; set; }

        [Display(Name ="CategorieCircuit")]
        public CategorieCircuit CategorieCircuit { get; set; }

        [Display(Name="Pret")]
        public double Pret { get; set; }

        //Relationships
        public List<Piloti_Cursa> Pilotii_Cursaa { get; set; }

        //Tara

        public int TaraId { get; set; }
        [ForeignKey("TaraId")]
        public Tara Tara { get; set; }
    }
}