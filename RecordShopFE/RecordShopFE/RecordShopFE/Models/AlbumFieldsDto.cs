using RecordShopFE.Validators;
using System.ComponentModel.DataAnnotations;

namespace RecordShopFE.Models
{
    public class AlbumFieldsDto

    {

        [Required(ErrorMessage = "Doit entrer un nom")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Doit inscrire un artiste")]
        public string Artist { get; set; }
        [ReleasedValidator(ErrorMessage = "base de données ne prend pas la musique avant l'existence de la France. Si c'est après 2035, contactez l'administrateur.")]
        public int Released { get; set; }
        [Required(ErrorMessage = "Doit entrer dans un gnere")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "doit entrer quelques informations")]
        public string Information { get; set; }
    }
}
