using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Skola.Mapiranje
{
    public class UciNaMapiranje : ClassMap<Skola.Entiteti.UciNa>
    {
        public UciNaMapiranje()
       {
           Table("UCI_NA");
           Id(x => x.UciNaId, "ID_UCI_NA").GeneratedBy.TriggerIdentity();
           References(x => x.UceNa).Column("ID_SMERA").LazyLoad();
           References(x => x.Uci).Column("ID_PREDMETA").LazyLoad();


       }
    }
}
