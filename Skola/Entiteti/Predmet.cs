﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Entiteti
{
    public class Predmet
    {
         public virtual int Id_Predmeta { get; set; }
        public virtual string NazivPredmeta { get; set; }

        public virtual IList<Smer> Smerovi { get; set; }
        public virtual IList<UciNa> Uci { get; set; }

        public virtual IList<NastavnoOsoblje> Nastavnici { get; set; }
        public virtual IList<AngazovanNa> Angazovan { get; set; }

        public virtual IList<Ocena> Ocene { get; set; }

        public virtual IList<Godine> Godine { get; set; }

        public Predmet()             
        {
            Godine = new List<Godine>();
            Nastavnici = new List<NastavnoOsoblje>();
            Angazovan = new List<AngazovanNa>();
            Smerovi = new List<Smer>();
            Uci = new List<UciNa>();
            Ocene = new List<Ocena>();
 
        }
    }
}
