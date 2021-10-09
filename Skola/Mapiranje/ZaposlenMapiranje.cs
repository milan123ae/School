using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Mapiranje
{
    public class ZaposlenMapiranje : ClassMap<Skola.Entiteti.Zaposlen>
    {
        public ZaposlenMapiranje()
        {
            Table("ZAPOSLEN");
            DiscriminateSubClassesOnColumn("TIP_OSOBLJA");

            Id(x => x.Jmbg).GeneratedBy.Assigned().Column("JMBG");

            Map(x => x.Lime).Column("L_IME");
            Map(x => x.ImeRoditelja).Column("IME_RODITELJA");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.DatumRodjenja).Column("DATUM_RODJENJA");
            Map(x => x.Ulica).Column("ULICA");
            Map(x => x.Broj).Column("BROJ");
           

        }
    }
    public class NastavnoOsobljeMapiranje : SubclassMap<Skola.Entiteti.NastavnoOsoblje>
    {
        public NastavnoOsobljeMapiranje()
        {
            DiscriminatorValue("NASTAVNO_OSOBLJE");
            //Table("NASTAVNO_OSOBLJE");
            Map(x => x.TipNorme).Column("TIP_NORME");
            Map(x => x.NazivSkole).Column("NAZIV_SKOLE");
            Map(x => x.BrojCasovaNedeljno).Column("BROJ_CASOVA_NEDELJNO");
            HasManyToMany(x => x.Predmetii)
                .Table("ANGAZOVAN_NA")
                .ParentKeyColumn("JMBG_NASTAVNIKA")
                .ChildKeyColumn("ID_PREDMETA");
               // .Inverse()
              //  .Cascade.All();      
           // HasMany(x => x.Angazovanje).KeyColumn("JMBG_NASTAVNIKA").LazyLoad();//.Cascade.All().Inverse();

        }

    }
    public class NenastavnoOsobljeMapiranje : SubclassMap<Skola.Entiteti.NenastavnoOsoblje>
    {
        public NenastavnoOsobljeMapiranje()
        {
            DiscriminatorValue("NENASTAVNO_OSOBLJE");
            //Table("NENASTAVNO_OSOBLJE");
            Map(x => x.StrucnaSprema).Column("STRUCNA_SPREMA");
            Map(x => x.NazivSektora).Column("NAZIV_SEKTORA");


        }

    }
}
