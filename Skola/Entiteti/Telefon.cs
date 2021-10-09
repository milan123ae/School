using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Entiteti
{
    public class Telefon
    {
        public virtual int IdTelefona { get; set; }
        public virtual int Telefonn { get; set; }
        public virtual Roditelji Roditeljifon { get; set; }
    }
}
