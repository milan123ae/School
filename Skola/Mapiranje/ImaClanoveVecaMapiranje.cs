using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Mapiranje
{
    public class ImaClanoveVecaMapiranje : ClassMap<Skola.Entiteti.ImaClanoveVeca>
    {
         public ImaClanoveVecaMapiranje()
       {
           Table("IMA_CLANOVE_VECA");
           Id(x => x.ImaClanoveVecaId, "ID_IMA_CLANOVE_VECA").GeneratedBy.TriggerIdentity();
           References(x => x.ImaClanove).Column("ID_UCENIKA");
           References(x => x.Roditelj).Column("ID_RODITELJA");
         
       }
    }
}
