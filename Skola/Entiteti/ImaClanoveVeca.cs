using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Entiteti
{
    public class ImaClanoveVeca
    {
        public virtual int ImaClanoveVecaId { get; set; }
        public virtual Ucenik ImaClanove { get; set; }
        public virtual Roditelji Roditelj { get; set; }
    }
}
