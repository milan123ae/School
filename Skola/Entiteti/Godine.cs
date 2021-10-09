using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Entiteti
{
    public class Godine
    {
        public virtual int IdGodine { get; set; }
        public virtual string Godina { get; set; }
        public virtual  Predmet Predmeti1 { get; set; }
    }
}
