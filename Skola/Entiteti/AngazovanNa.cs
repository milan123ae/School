using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Entiteti
{
    public class AngazovanNa
    {
        public virtual int Id { get; set; }
        public virtual NastavnoOsoblje Angazovanje { get; set; }
        public virtual Predmet Angazovan { get; set; }
        public virtual DateTime DatumAngazovanja { get; set; }

        public AngazovanNa()
        {
        }
    }
}
