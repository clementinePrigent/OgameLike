using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_OgameLike
{
    public class Ressource : IDbEntity
    {
        public long Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [StringLength(20, MinimumLength = 5)]
        [RegularExpression("énergie|oxygène|acier|uranium", ErrorMessage = "La ressources doit être de type énergie, oxygène, acier ou uranium.")]
        public string Name { get; set; }
        public int? LastQuantity { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}"
           , ApplyFormatInEditMode = true)]
        [Validation(ErrorMessage =
           "La date ne peut pas être inférieure à la date du jour.")]
        public DateTime LastUpdate { get; set; }

    
    }
}
