using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Mapiranje
{
    public class TelefonMapiranje : ClassMap<Skola.Entiteti.Telefon>
    {
        public TelefonMapiranje()
        {
            Table("TELEFON");
            Id(x => x.IdTelefona, "ID_TELEFONA").GeneratedBy.TriggerIdentity();
            Map(x => x.Telefonn).Column("TELEFON");
            References(x => x.Roditeljifon).Column("ID_RODITELJA").LazyLoad();
        }
    }
}
