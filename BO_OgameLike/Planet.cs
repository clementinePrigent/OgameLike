using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BO_OgameLike
{
    public class Planet : IDbEntity
    {
        public long Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }
        public int? caseNB { get; set; }

        [MaxLength(4)]
        public List<Ressource> Ressources { get; set; } = new List<Ressource>();
        public List<Building> Buildings { get; set; } = new List<Building>();
    }
}