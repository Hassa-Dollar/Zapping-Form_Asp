using System.ComponentModel.DataAnnotations;

namespace Zapping_Form_Asp.Models
{
    public class CompteBanquaire : IValidatableObject
    {
        [Required(ErrorMessage = "Ce champ est requis")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Ce champ est requis")]
        public string Prenom { get; set; }

        [Display(Name = "Date de naissance")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType("Date")]
        [Required(ErrorMessage = "Ce champ est requis")]
        public DateTime DateNaissance { get; set; }

        [Display(Name = "Numero de téléphone")]
        [Required(ErrorMessage = "Ce champ est requis")]
        public string NumTelephone { get; set; }

        [Required(ErrorMessage = "Ce champ est requis")]
        public string Rue { get; set; }

        [Required(ErrorMessage = "Ce champ est requis")]
        public string Ville { get; set; }

        [Display(Name = "Numero civic")]
        [Range(0, double.MaxValue, ErrorMessage =
        "Le numéro civique doit être un nombre positif.")]
        [Required(ErrorMessage = "Ce champ est requis")]
        public int NumeroCivique { get; set; }

        [Required(ErrorMessage = "Ce champ est requis")]
        public string Employeur { get; set; }

        [Range(0, double.MaxValue, ErrorMessage =
        "Le salaire doit être un nombre positif.")]
        [Required(ErrorMessage = "Ce champ est requis")]
        public decimal Salaire { get; set; }

        [Display(Name = "Depot initial")]
        [Range(0, double.MaxValue, ErrorMessage =
        "Le dépôt initial doit être un nombre positif.")]
        [Required(ErrorMessage = "Ce champ est requis")]
        public decimal DepotInitial { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> results = new List<ValidationResult>();

            if (DateNaissance > DateTime.Now)
            {
                results.Add(new ValidationResult("La date ne peut pas être après aujourd'hui",
                    new[] { "DateNaissance" }));
            }
            return results;
        }
    }
}
