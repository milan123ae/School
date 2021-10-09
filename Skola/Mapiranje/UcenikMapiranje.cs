using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Mapiranje
{
    public class UcenikMapiranje : ClassMap<Skola.Entiteti.Ucenik>
    {
         public UcenikMapiranje()
        {
            Table("UCENIK");
            Id(x => x.IdUcenika, "ID_Ucenika").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Razred).Column("RAZRED");
            Map(x => x.Ulica).Column("ULICA");
            Map(x => x.Broj).Column("BROJ");
            Map(x => x.DatumUpisa).Column("DATUM_UPISA");

            HasMany(x => x.Ocenee).KeyColumn("ID_UCENIKA").LazyLoad().Cascade.DeleteOrphan().Inverse();
            References(x => x.UpisaoSmer).Column("ID_SMERA").LazyLoad();

            HasManyToMany(x => x.Roditelj)
                   .Table("IMA_CLANOVE_VECA")
                   .ParentKeyColumn("ID_UCENIKA")
                   .ChildKeyColumn("ID_RODITELJA");
                   //.Cascade.All();
           // HasMany(x => x.ImaClanove).KeyColumn("ID_UCENIKA").LazyLoad().Cascade.All().Inverse();


        }
    }
}
