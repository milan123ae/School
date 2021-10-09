using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Mapiranje
{
    public class RoditeljiMapiranje : ClassMap<Skola.Entiteti.Roditelji>
    {
        public RoditeljiMapiranje()
        {
            Table("RODITELJI");
            Id(x => x.IdRoditelja, "ID_RODITELJA").GeneratedBy.TriggerIdentity();
            Map(x => x.ImeRod).Column("IME_ROD");
            Map(x => x.PrezimeRod).Column("PREZIME_ROD");

            HasMany(x => x.Telefoni).KeyColumn("ID_RODITELJA").LazyLoad().Cascade.DeleteOrphan().Inverse();

            HasManyToMany(x => x.Ucenici)
             .Table("IMA_CLANOVE_VECA")
             .ParentKeyColumn("ID_RODITELJA")
             .ChildKeyColumn("ID_UCENIKA");
             //.Cascade.All().Inverse();
           // HasMany(x => x.ImaClanoveRod).KeyColumn("ID_RODITELJA").LazyLoad().Cascade.All().Inverse();

        }
    }
}
