using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Mapiranje
{
    public class GodineMapiranje : ClassMap<Skola.Entiteti.Godine>
    {
        public GodineMapiranje()
        {
            Table("GODINE");
            Id(x => x.IdGodine, "ID_GODINE").GeneratedBy.TriggerIdentity();
            Map(x => x.Godina).Column("GODINA");
            References(x => x.Predmeti1).Column("ID_PREDMETA").LazyLoad();
        }
    }
}
