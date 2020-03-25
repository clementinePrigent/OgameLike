using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_OgameLike
{
    public class SolarSystem : IDbEntity
    {
        public long Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        public List<Planet> Planets { get; set; } = new List<Planet>();


    }
}
