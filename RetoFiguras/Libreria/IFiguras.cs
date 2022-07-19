using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public interface IFiguras
    {
        public String Texto { get; set; }

        public float Area();
        public float Capacidad();
        public String Estado();
    }
}
