using System.ComponentModel.DataAnnotations;

namespace Zapping_Form_Asp.Models
{
    public class CompteBanquaire : IValidatableObject
    {
        [Required(ErrorMessage = "Ce champ est rquis")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Ce champ est rquis")]
        public string Prenom { get; set; }

        [Display(Name = "Date de naissance")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType("Date")]
        [Required(ErrorMessage = "Ce champ est rquis")]
        public DateTime DateNaissance { get; set; }

        [Display(Name = "Numero de telephone")]
        [Required(ErrorMessage = "Ce champ est rquis")]
        public string NumTelephone { get; set; }

        [Required(ErrorMessage = "Ce champ est rquis")]
        public string Rue { get; set; }

        [Required(ErrorMessage = "Ce champ est rquis")]
        public string Ville { get; set; }

        [Display(Name = "Numero civic")]
        [Range(0, double.MaxValue, ErrorMessage =
        "Le Numero Civic doit etre un nombre positif.")]
        [Required(ErrorMessage = "Ce champ est rquis")]
        public int NumeroCivic { get; set; }

        [Required(ErrorMessage = "Ce champ est rquis")]
        public string Employeur { get; set; }

        [Range(0, double.MaxValue, ErrorMessage =
        "Le salaire doit etre un nombre positif.")]
        [Required(ErrorMessage = "Ce champ est rquis")]
        public decimal Salaire { get; set; }

        [Display(Name = "Depot initial")]
        [Range(0, double.MaxValue, ErrorMessage =
        "Le Depot Initial doit etre un nombre positif.")]
        [Required(ErrorMessage = "Ce champ est rquis")]
        public decimal DepotInitial { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> results = new List<ValidationResult>();

            if (DateNaissance > DateTime.Now)
            {
                results.Add(new ValidationResult("La date ne peut pas etre apres aujourd'hui",
                    new[] { "DateNaissance" }));
            }
            return results;
        }
    }
}
