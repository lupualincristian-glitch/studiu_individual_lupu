using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AplicatieWeb.Models
{
    public class Rezultat
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Numele sportivului este obligatoriu.")]
        [Display(Name = "Nume Sportiv")]
        public string NumeSportiv { get; set; } = string.Empty;

        [Required(ErrorMessage = "Selectați proba.")]
        [Display(Name = "Proba")]
        public string Proba { get; set; } = string.Empty;

        [Required(ErrorMessage = "Locul este obligatoriu.")]
        [Range(1, 1000, ErrorMessage = "Locul trebuie să fie un număr pozitiv.")]
        [Display(Name = "Locul")]
        public int Loc { get; set; }

        [Required(ErrorMessage = "Punctajul este obligatoriu.")]
        [Range(0, 10000, ErrorMessage = "Punctajul trebuie să fie pozitiv.")]
        [Precision(10, 2)]
        [Display(Name = "Punctaj")]
        public decimal Punctaj { get; set; }

        [Required(ErrorMessage = "Data concursului este obligatorie.")]
        [DataType(DataType.Date)]
        [Display(Name = "Data Concursului")]
        public DateTime DataConcursului { get; set; }

        [Display(Name = "Calificat")]
        public bool Calificat { get; set; }
    }
}