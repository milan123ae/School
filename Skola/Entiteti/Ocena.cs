using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Entiteti
{
    public class Ocena
    {
        public virtual int Id_Ocena { get; set; }
        public virtual int Vrednost { get; set; }
        public virtual string Opis { get; set; }
        public virtual DateTime DatumDobijanjaOcene { get; set; }

        public virtual Ucenik UpisaoUcenik { get; set; }
        public virtual Predmet UpisaoPredmet { get; set; }

        public Ocena()
        {
        }

    }
}
