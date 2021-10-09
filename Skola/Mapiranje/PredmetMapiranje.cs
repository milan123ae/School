using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Mapiranje
{
    public class PredmetMapiranje : ClassMap<Skola.Entiteti.Predmet>
    {
        public PredmetMapiranje()
        {
            Table("PREDMET");
            Id(x => x.Id_Predmeta, "ID_PREDMETA").GeneratedBy.TriggerIdentity();
            Map(x => x.NazivPredmeta).Column("NAZIV_PREDMETA");

            HasMany(x => x.Godine).KeyColumn("ID_PREDMETA").Cascade.DeleteOrphan().Inverse();

            HasManyToMany(x => x.Smerovi)
            .Table("UCI_NA")
            .ParentKeyColumn("ID_PREDMETA")
            .ChildKeyColumn("ID_SMERA");
            //.Cascade.DeleteOrphan();
           // HasMany(x => x.Uci).KeyColumn("ID_PREDMETA").LazyLoad().Inverse();//.Cascade.All().Inverse();

            HasManyToMany(x => x.Nastavnici)
              .Table("ANGAZOVAN_NA")
              .ParentKeyColumn("ID_PREDMETA")
              .ChildKeyColumn("JMBG_NASTAVNIKA");
              //.Cascade.All();
           // HasMany(x => x.Angazovan).KeyColumn("ID_PREDMETA").LazyLoad();//Cascade.All().Inverse();

            HasMany(x => x.Ocene).KeyColumn("ID_PREDMETA").Cascade.DeleteOrphan().Inverse();


        }
    }
}
