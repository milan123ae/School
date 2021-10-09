using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Entiteti
{
    public class UciNa
    {
        public virtual int UciNaId { get; set; }

        public virtual Predmet Uci { get; set; }
        public virtual Smer UceNa { get; set; }


    }
}
