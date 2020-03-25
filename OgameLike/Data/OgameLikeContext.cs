using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OgameLike.Data
{
    public class OgameLikeContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public OgameLikeContext() : base("name=OgameLikeContext")
        {
        }

        public System.Data.Entity.DbSet<BO_OgameLike.Building> Buildings { get; set; }

        public System.Data.Entity.DbSet<BO_OgameLike.Planet> Planets { get; set; }

        public System.Data.Entity.DbSet<BO_OgameLike.Ressource> Ressources { get; set; }

        public System.Data.Entity.DbSet<BO_OgameLike.SolarSystem> SolarSystems { get; set; }

        public System.Data.Entity.DbSet<BO_OgameLike.RessourceGenerator> RessourceGenerators { get; set; }

        public System.Data.Entity.DbSet<BO_OgameLike.FunctionBuilding> FunctionBuildings { get; set; }
    }
}
