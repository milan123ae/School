using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Skola.Mapiranje
{
    public class AngazovanNaMapiranje : ClassMap<Skola.Entiteti.AngazovanNa>
    {
       public AngazovanNaMapiranje()
        {
            Table("ANGAZOVAN_NA");

            Id(x => x.Id, "ID_ANGAZOVAN").GeneratedBy.TriggerIdentity();

            References(x => x.Angazovan, "ID_PREDMETA"); 

            References(x => x.Angazovanje, "JMBG_NASTAVNIKA");


            Map(x => x.DatumAngazovanja).Column("DATUM_ANGAZOVANJA");
        }

    }
}
