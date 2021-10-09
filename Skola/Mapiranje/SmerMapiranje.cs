using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Mapiranje
{
    public class SmerMapiranje : ClassMap<Skola.Entiteti.Smer>
    {
        public SmerMapiranje()
        {
            Table("SMER");
            Id(x => x.IdSmera, "ID_SMERA").GeneratedBy.TriggerIdentity();
            Map(x => x.NazivSmera).Column("NAZIV_SMERA");
            Map(x => x.BrojUcenika).Column("BROJ_UCENIKA");

            HasMany(x => x.Ucenici).KeyColumn("ID_SMERA").LazyLoad().Cascade.DeleteOrphan().Inverse(); 

            HasManyToMany(x => x.Predmeti)
             .Table("UCI_NA")
             .ParentKeyColumn("ID_SMERA")
             .ChildKeyColumn("ID_PREDMETA");
            // .Cascade.All();
            //HasMany(x => x.UceNa).KeyColumn("ID_SMERA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
