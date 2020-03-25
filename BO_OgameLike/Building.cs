using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_OgameLike
{
    public abstract class Building : IDbEntity
    {
        public long Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        public abstract int? CellNb();
        public int TotalCost(List<Ressource> ressources) {
            var total = ressources.Count();
            return total;
        }
        public List<Ressource> NextCost()
        {
            List<Ressource> List = new List<Ressource>();

            return List;
        }
    }
}
