using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Skola.Mapiranje
{
    public class OcenaMapiranje : ClassMap<Skola.Entiteti.Ocena>
    {
       public OcenaMapiranje()
        {
            Table("OCENA");
            Id(x => x.Id_Ocena, "ID_OCENA").GeneratedBy.TriggerIdentity();

            Map(x => x.Vrednost).Column("VREDNOST");
            Map(x => x.Opis).Column("OPIS");
            Map(x => x.DatumDobijanjaOcene).Column("DATUM_DOBIJANJA");
            References(x => x.UpisaoUcenik).Column("ID_UCENIKA").LazyLoad();
            References(x => x.UpisaoPredmet).Column("ID_PREDMETA").LazyLoad();

        }
    }
}
